<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAlvara
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
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim BombeirosSituacaoLabel As System.Windows.Forms.Label
        Dim BombeiroNProcessoLabel As System.Windows.Forms.Label
        Dim AmbientalDataProvisorioLabel As System.Windows.Forms.Label
        Dim ViabilidadeExigenciaLabel As System.Windows.Forms.Label
        Dim SanitarioExigenciaLabel As System.Windows.Forms.Label
        Dim SetranExigenciaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ModeloSistemaLabel As System.Windows.Forms.Label
        Dim SituacaoLabel As System.Windows.Forms.Label
        Dim AvisarDiaLabel As System.Windows.Forms.Label
        Dim DataCriadoLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim NaturezaDoPedidoLabel As System.Windows.Forms.Label
        Dim RequerenteLabel As System.Windows.Forms.Label
        Dim EndRequerenteLabel As System.Windows.Forms.Label
        Dim FoneRequerenteLabel As System.Windows.Forms.Label
        Dim EmailRequerenteLabel As System.Windows.Forms.Label
        Dim CPFRequerenteLabel As System.Windows.Forms.Label
        Dim RGRequerenteLabel As System.Windows.Forms.Label
        Dim CNPJRequerenteLabel As System.Windows.Forms.Label
        Dim CNAELabel As System.Windows.Forms.Label
        Dim RamodeatividadeLabel As System.Windows.Forms.Label
        Dim ResptecnicoNumeroLabel As System.Windows.Forms.Label
        Dim ResptecnicoLabel As System.Windows.Forms.Label
        Dim EndCidadeLabel As System.Windows.Forms.Label
        Dim EndEstadoLabel As System.Windows.Forms.Label
        Dim EndBairroLabel As System.Windows.Forms.Label
        Dim EndCompLabel As System.Windows.Forms.Label
        Dim EndNumLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim EndCEPLabel As System.Windows.Forms.Label
        Dim EndZonaLabel As System.Windows.Forms.Label
        Dim EndQuadraLabel As System.Windows.Forms.Label
        Dim EndDataLabel As System.Windows.Forms.Label
        Dim CadImobLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim Area2Label As System.Windows.Forms.Label
        Dim PontoRefLabel As System.Windows.Forms.Label
        Dim NaturezaDoPedidoOBSLabel As System.Windows.Forms.Label
        Dim ProtocoloTipoLabel As System.Windows.Forms.Label
        Dim ProtocoloNLabel As System.Windows.Forms.Label
        Dim ProtocoloAnoLabel As System.Windows.Forms.Label
        Dim ProtocoloSenhaLabel As System.Windows.Forms.Label
        Dim HistoricoLabel As System.Windows.Forms.Label
        Dim BombeiroSituacaoLabel As System.Windows.Forms.Label
        Dim EndCidadeLabel1 As System.Windows.Forms.Label
        Dim EndEstadoLabel1 As System.Windows.Forms.Label
        Dim OrgaoRGRequerenteLabel As System.Windows.Forms.Label
        Dim EstadoOrgaoRGRequerenteLabel As System.Windows.Forms.Label
        Dim NumeroProcessoLabel As System.Windows.Forms.Label
        Dim ReciboProcessoLabel As System.Windows.Forms.Label
        Dim MatrizLabel As System.Windows.Forms.Label
        Dim NlaudoSecundarioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlvara))
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.LaudosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaudosTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.LaudosTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.LaudosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BombeirosCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SetranSituacaoComboBox = New System.Windows.Forms.ComboBox()
        Me.SanitarioSituacaoComboBox = New System.Windows.Forms.ComboBox()
        Me.ViabilidadeSituacaoComboBox = New System.Windows.Forms.ComboBox()
        Me.AmbientalSituacaoComboBox = New System.Windows.Forms.ComboBox()
        Me.SetranCheckBox = New System.Windows.Forms.CheckBox()
        Me.SanitarioCheckBox = New System.Windows.Forms.CheckBox()
        Me.ViabilidadeCheckBox = New System.Windows.Forms.CheckBox()
        Me.AmbientalCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabControlAcompanhamento = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDatProvBombeiro = New System.Windows.Forms.GroupBox()
        Me.ButtonApagaDataBombeiro = New System.Windows.Forms.PictureBox()
        Me.BombeiroProvisorioDATAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAddDataBombeiro = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelBombeiroMulta = New System.Windows.Forms.Label()
        Me.BombeiroDataMultaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BtnMultaBombeiro = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.BtnProcotBomb = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.BombeiroNProcessoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BombeiroDataPedProcessoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BombeiroExigenciaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDatProvAmbiental = New System.Windows.Forms.GroupBox()
        Me.AmbientalProvisorioDATAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAddDataAmbiental = New System.Windows.Forms.PictureBox()
        Me.ButtonApagaDataAmbiental = New System.Windows.Forms.PictureBox()
        Me.AmbientalExigenciaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDatProvViabilidade = New System.Windows.Forms.GroupBox()
        Me.ViabilidadeProvisorioDATAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAddDataViabilidade = New System.Windows.Forms.PictureBox()
        Me.ButtonApagaDataViabilidade = New System.Windows.Forms.PictureBox()
        Me.ViabilidadeExigenciaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDatProvSanitario = New System.Windows.Forms.GroupBox()
        Me.SanitarioProvisorioDATAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAddDataSanitario = New System.Windows.Forms.PictureBox()
        Me.ButtonApagaDataSanitario = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Sanitariocontrole3TextBox = New System.Windows.Forms.TextBox()
        Me.Sanitariocontrole2TextBox = New System.Windows.Forms.TextBox()
        Me.Sanitariocontrole1TextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SanitarioExigenciaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDatProvSetran = New System.Windows.Forms.GroupBox()
        Me.SetranProvisorioDATAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAddDataSetran = New System.Windows.Forms.PictureBox()
        Me.ButtonApagaDataSetran = New System.Windows.Forms.PictureBox()
        Me.SetranExigenciaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.NlaudoTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloSistemaComboBox = New System.Windows.Forms.ComboBox()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.ComboBoxBuscaAlvara = New System.Windows.Forms.ComboBox()
        Me.BtnCalendarioWindows = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelSetranDataProvisorio = New System.Windows.Forms.Label()
        Me.LabelSanitarioDataProvisorio = New System.Windows.Forms.Label()
        Me.LabelViabilidadeDataProvisorio = New System.Windows.Forms.Label()
        Me.LabelAmbientalDataProvisorio = New System.Windows.Forms.Label()
        Me.LabelBombeiroDataProvisorio = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CADSituacaoAlvaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnVerObsGeral = New System.Windows.Forms.Button()
        Me.NlaudoSecundarioTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacaoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BtnAnotacoes = New System.Windows.Forms.Button()
        Me.NlaudoLabel = New System.Windows.Forms.Label()
        Me.BtnBombVer = New System.Windows.Forms.Button()
        Me.BombeiroSituacaoComboBox = New System.Windows.Forms.ComboBox()
        Me.TabAlvara = New System.Windows.Forms.TabControl()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.BtnAtualizarDados = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.NaturezaDoPedidoOBSRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.BtnCopiaCEP = New System.Windows.Forms.Button()
        Me.BtnMapa = New System.Windows.Forms.Button()
        Me.EndCidadeTextBox = New System.Windows.Forms.TextBox()
        Me.PontoRefTextBox = New System.Windows.Forms.TextBox()
        Me.EndBairroTextBox = New System.Windows.Forms.TextBox()
        Me.EndCompTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Area2TextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.CadImobTextBox = New System.Windows.Forms.TextBox()
        Me.EndDataTextBox = New System.Windows.Forms.TextBox()
        Me.EndQuadraTextBox = New System.Windows.Forms.TextBox()
        Me.EndZonaTextBox = New System.Windows.Forms.TextBox()
        Me.EndNumTextBox = New System.Windows.Forms.TextBox()
        Me.EndEstadoTextBox = New System.Windows.Forms.TextBox()
        Me.EndCEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.ResptecnicoTextBox = New System.Windows.Forms.TextBox()
        Me.ResptecnicoNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.BtnGrauDeRisco = New System.Windows.Forms.Button()
        Me.RamodeatividadeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CNAERichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.BtnImportaSocio = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.EstadoOrgaoRGRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.CNPJRequerenteMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.OrgaoRGRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.RGRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.CPFRequerenteMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.FoneRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.EndRequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.RequerenteTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.NaturezaDoPedidoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.NaturezaListBox = New System.Windows.Forms.ListBox()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BtnContLigacao = New System.Windows.Forms.Button()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.BtnCadSite = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.BtnAnotacoesPref = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxProtocolo = New System.Windows.Forms.GroupBox()
        Me.BtnAgoraProt = New System.Windows.Forms.Button()
        Me.LblProtocolo2 = New System.Windows.Forms.Label()
        Me.LblProtocolo1 = New System.Windows.Forms.Label()
        Me.BtnNovoProtocolo = New System.Windows.Forms.Button()
        Me.ReciboProcessoTextBox = New System.Windows.Forms.TextBox()
        Me.ProtocoloSenhaTextBox = New System.Windows.Forms.TextBox()
        Me.DataEntradaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataEntradaLabel = New System.Windows.Forms.Label()
        Me.NumeroProcessoTextBox = New System.Windows.Forms.TextBox()
        Me.ProtocoloAnoTextBox = New System.Windows.Forms.TextBox()
        Me.ProtocoloNTextBox = New System.Windows.Forms.TextBox()
        Me.ProtocoloTipoTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage16 = New System.Windows.Forms.TabPage()
        Me.HistoricoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ButtonSolicitar = New System.Windows.Forms.Button()
        Me.BtnAnotacoesLEgalizacao = New System.Windows.Forms.Button()
        Me.CMCTextBox = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnCopiarRegistro = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNovaAlteracao = New System.Windows.Forms.Button()
        Me.Btnempresa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.AvisarDiaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataCriadoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CMCLabel = New System.Windows.Forms.LinkLabel()
        Me.CheckBoxPrioridade = New System.Windows.Forms.GroupBox()
        Me.BtnFiliais = New System.Windows.Forms.Button()
        Me.MatrizComboBox = New System.Windows.Forms.ComboBox()
        Me.LabelFilial = New System.Windows.Forms.Label()
        Me.PrioridadeCheckBox = New System.Windows.Forms.CheckBox()
        Me.BtnVerificar = New System.Windows.Forms.Button()
        Me.BtnMgsBoxAvisarDia = New System.Windows.Forms.Button()
        Me.LembreteCheckBox = New System.Windows.Forms.CheckBox()
        Me.CNPJLabel = New System.Windows.Forms.Label()
        Me.SituacaoComboBox = New System.Windows.Forms.ComboBox()
        Me.EndEstadoLabel2 = New System.Windows.Forms.Label()
        Me.EndCidadeLabel2 = New System.Windows.Forms.Label()
        Me.BtnData1 = New System.Windows.Forms.Button()
        Me.CADSituacaoAlvaraTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CADSituacaoAlvaraTableAdapter()
        Me.BtnLocalizar = New System.Windows.Forms.Button()
        Me.ComboBoxBuscaCNPJ = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.BtnExportarWord = New System.Windows.Forms.Button()
        Me.GroupBoxCima = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTipMostraDescricao = New System.Windows.Forms.ToolTip(Me.components)
        Me.BombeiroSituacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BombeiroSituacaoTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.BombeiroSituacaoTableAdapter()
        Me.AlvaraSistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlvaraSistemaTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.AlvaraSistemaTableAdapter()
        RazaoSocialLabel = New System.Windows.Forms.Label()
        BombeirosSituacaoLabel = New System.Windows.Forms.Label()
        BombeiroNProcessoLabel = New System.Windows.Forms.Label()
        AmbientalDataProvisorioLabel = New System.Windows.Forms.Label()
        ViabilidadeExigenciaLabel = New System.Windows.Forms.Label()
        SanitarioExigenciaLabel = New System.Windows.Forms.Label()
        SetranExigenciaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ModeloSistemaLabel = New System.Windows.Forms.Label()
        SituacaoLabel = New System.Windows.Forms.Label()
        AvisarDiaLabel = New System.Windows.Forms.Label()
        DataCriadoLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        NaturezaDoPedidoLabel = New System.Windows.Forms.Label()
        RequerenteLabel = New System.Windows.Forms.Label()
        EndRequerenteLabel = New System.Windows.Forms.Label()
        FoneRequerenteLabel = New System.Windows.Forms.Label()
        EmailRequerenteLabel = New System.Windows.Forms.Label()
        CPFRequerenteLabel = New System.Windows.Forms.Label()
        RGRequerenteLabel = New System.Windows.Forms.Label()
        CNPJRequerenteLabel = New System.Windows.Forms.Label()
        CNAELabel = New System.Windows.Forms.Label()
        RamodeatividadeLabel = New System.Windows.Forms.Label()
        ResptecnicoNumeroLabel = New System.Windows.Forms.Label()
        ResptecnicoLabel = New System.Windows.Forms.Label()
        EndCidadeLabel = New System.Windows.Forms.Label()
        EndEstadoLabel = New System.Windows.Forms.Label()
        EndBairroLabel = New System.Windows.Forms.Label()
        EndCompLabel = New System.Windows.Forms.Label()
        EndNumLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        EndCEPLabel = New System.Windows.Forms.Label()
        EndZonaLabel = New System.Windows.Forms.Label()
        EndQuadraLabel = New System.Windows.Forms.Label()
        EndDataLabel = New System.Windows.Forms.Label()
        CadImobLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        Area2Label = New System.Windows.Forms.Label()
        PontoRefLabel = New System.Windows.Forms.Label()
        NaturezaDoPedidoOBSLabel = New System.Windows.Forms.Label()
        ProtocoloTipoLabel = New System.Windows.Forms.Label()
        ProtocoloNLabel = New System.Windows.Forms.Label()
        ProtocoloAnoLabel = New System.Windows.Forms.Label()
        ProtocoloSenhaLabel = New System.Windows.Forms.Label()
        HistoricoLabel = New System.Windows.Forms.Label()
        BombeiroSituacaoLabel = New System.Windows.Forms.Label()
        EndCidadeLabel1 = New System.Windows.Forms.Label()
        EndEstadoLabel1 = New System.Windows.Forms.Label()
        OrgaoRGRequerenteLabel = New System.Windows.Forms.Label()
        EstadoOrgaoRGRequerenteLabel = New System.Windows.Forms.Label()
        NumeroProcessoLabel = New System.Windows.Forms.Label()
        ReciboProcessoLabel = New System.Windows.Forms.Label()
        MatrizLabel = New System.Windows.Forms.Label()
        NlaudoSecundarioLabel = New System.Windows.Forms.Label()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaudosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LaudosBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControlAcompanhamento.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBoxDatProvBombeiro.SuspendLayout()
        CType(Me.ButtonApagaDataBombeiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonAddDataBombeiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBoxDatProvAmbiental.SuspendLayout()
        CType(Me.ButtonAddDataAmbiental, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonApagaDataAmbiental, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBoxDatProvViabilidade.SuspendLayout()
        CType(Me.ButtonAddDataViabilidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonApagaDataViabilidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBoxDatProvSanitario.SuspendLayout()
        CType(Me.ButtonAddDataSanitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonApagaDataSanitario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBoxDatProvSetran.SuspendLayout()
        CType(Me.ButtonAddDataSetran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonApagaDataSetran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CADSituacaoAlvaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabAlvara.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        Me.TabPage15.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProtocolo.SuspendLayout()
        Me.TabPage16.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CheckBoxPrioridade.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBoxCima.SuspendLayout()
        CType(Me.BombeiroSituacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlvaraSistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.BackColor = System.Drawing.Color.Transparent
        RazaoSocialLabel.Location = New System.Drawing.Point(5, 48)
        RazaoSocialLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(83, 15)
        RazaoSocialLabel.TabIndex = 1
        RazaoSocialLabel.Text = "Razão Social:"
        '
        'BombeirosSituacaoLabel
        '
        BombeirosSituacaoLabel.AutoSize = True
        BombeirosSituacaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BombeirosSituacaoLabel.Location = New System.Drawing.Point(65, 30)
        BombeirosSituacaoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BombeirosSituacaoLabel.Name = "BombeirosSituacaoLabel"
        BombeirosSituacaoLabel.Size = New System.Drawing.Size(58, 15)
        BombeirosSituacaoLabel.TabIndex = 6
        BombeirosSituacaoLabel.Text = "Situação:"
        '
        'BombeiroNProcessoLabel
        '
        BombeiroNProcessoLabel.AutoSize = True
        BombeiroNProcessoLabel.Location = New System.Drawing.Point(28, 25)
        BombeiroNProcessoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BombeiroNProcessoLabel.Name = "BombeiroNProcessoLabel"
        BombeiroNProcessoLabel.Size = New System.Drawing.Size(61, 15)
        BombeiroNProcessoLabel.TabIndex = 3
        BombeiroNProcessoLabel.Text = "Processo:"
        '
        'AmbientalDataProvisorioLabel
        '
        AmbientalDataProvisorioLabel.AutoSize = True
        AmbientalDataProvisorioLabel.Location = New System.Drawing.Point(13, 15)
        AmbientalDataProvisorioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AmbientalDataProvisorioLabel.Name = "AmbientalDataProvisorioLabel"
        AmbientalDataProvisorioLabel.Size = New System.Drawing.Size(81, 15)
        AmbientalDataProvisorioLabel.TabIndex = 0
        AmbientalDataProvisorioLabel.Text = "EXIGÊNCIAS:"
        '
        'ViabilidadeExigenciaLabel
        '
        ViabilidadeExigenciaLabel.AutoSize = True
        ViabilidadeExigenciaLabel.Location = New System.Drawing.Point(13, 15)
        ViabilidadeExigenciaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ViabilidadeExigenciaLabel.Name = "ViabilidadeExigenciaLabel"
        ViabilidadeExigenciaLabel.Size = New System.Drawing.Size(81, 15)
        ViabilidadeExigenciaLabel.TabIndex = 0
        ViabilidadeExigenciaLabel.Text = "EXIGÊNCIAS:"
        '
        'SanitarioExigenciaLabel
        '
        SanitarioExigenciaLabel.AutoSize = True
        SanitarioExigenciaLabel.Location = New System.Drawing.Point(13, 15)
        SanitarioExigenciaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SanitarioExigenciaLabel.Name = "SanitarioExigenciaLabel"
        SanitarioExigenciaLabel.Size = New System.Drawing.Size(81, 15)
        SanitarioExigenciaLabel.TabIndex = 0
        SanitarioExigenciaLabel.Text = "EXIGÊNCIAS:"
        '
        'SetranExigenciaLabel
        '
        SetranExigenciaLabel.AutoSize = True
        SetranExigenciaLabel.Location = New System.Drawing.Point(13, 15)
        SetranExigenciaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SetranExigenciaLabel.Name = "SetranExigenciaLabel"
        SetranExigenciaLabel.Size = New System.Drawing.Size(81, 15)
        SetranExigenciaLabel.TabIndex = 0
        SetranExigenciaLabel.Text = "EXIGÊNCIAS:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(3, 15)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(81, 15)
        Label1.TabIndex = 12
        Label1.Text = "EXIGÊNCIAS:"
        '
        'ModeloSistemaLabel
        '
        ModeloSistemaLabel.AutoSize = True
        ModeloSistemaLabel.Location = New System.Drawing.Point(65, 87)
        ModeloSistemaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ModeloSistemaLabel.Name = "ModeloSistemaLabel"
        ModeloSistemaLabel.Size = New System.Drawing.Size(55, 15)
        ModeloSistemaLabel.TabIndex = 38
        ModeloSistemaLabel.Text = "Sistema:"
        '
        'SituacaoLabel
        '
        SituacaoLabel.AutoSize = True
        SituacaoLabel.BackColor = System.Drawing.Color.Transparent
        SituacaoLabel.Location = New System.Drawing.Point(271, 108)
        SituacaoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SituacaoLabel.Name = "SituacaoLabel"
        SituacaoLabel.Size = New System.Drawing.Size(58, 15)
        SituacaoLabel.TabIndex = 51
        SituacaoLabel.Text = "Situação:"
        '
        'AvisarDiaLabel
        '
        AvisarDiaLabel.AutoSize = True
        AvisarDiaLabel.BackColor = System.Drawing.Color.Transparent
        AvisarDiaLabel.Location = New System.Drawing.Point(15, 138)
        AvisarDiaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AvisarDiaLabel.Name = "AvisarDiaLabel"
        AvisarDiaLabel.Size = New System.Drawing.Size(64, 15)
        AvisarDiaLabel.TabIndex = 69
        AvisarDiaLabel.Text = "Avisar Dia:"
        '
        'DataCriadoLabel
        '
        DataCriadoLabel.AutoSize = True
        DataCriadoLabel.BackColor = System.Drawing.Color.Transparent
        DataCriadoLabel.Location = New System.Drawing.Point(36, 109)
        DataCriadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataCriadoLabel.Name = "DataCriadoLabel"
        DataCriadoLabel.Size = New System.Drawing.Size(52, 15)
        DataCriadoLabel.TabIndex = 67
        DataCriadoLabel.Text = "Criação:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.BackColor = System.Drawing.Color.Transparent
        ObservacaoLabel.Location = New System.Drawing.Point(439, 10)
        ObservacaoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(75, 15)
        ObservacaoLabel.TabIndex = 73
        ObservacaoLabel.Text = "Observação:"
        '
        'NaturezaDoPedidoLabel
        '
        NaturezaDoPedidoLabel.AutoSize = True
        NaturezaDoPedidoLabel.Location = New System.Drawing.Point(12, 20)
        NaturezaDoPedidoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NaturezaDoPedidoLabel.Name = "NaturezaDoPedidoLabel"
        NaturezaDoPedidoLabel.Size = New System.Drawing.Size(121, 15)
        NaturezaDoPedidoLabel.TabIndex = 27
        NaturezaDoPedidoLabel.Text = "Natureza Do Pedido:"
        '
        'RequerenteLabel
        '
        RequerenteLabel.AutoSize = True
        RequerenteLabel.Location = New System.Drawing.Point(24, 28)
        RequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RequerenteLabel.Name = "RequerenteLabel"
        RequerenteLabel.Size = New System.Drawing.Size(44, 15)
        RequerenteLabel.TabIndex = 24
        RequerenteLabel.Text = "Nome:"
        '
        'EndRequerenteLabel
        '
        EndRequerenteLabel.AutoSize = True
        EndRequerenteLabel.Location = New System.Drawing.Point(4, 162)
        EndRequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndRequerenteLabel.Name = "EndRequerenteLabel"
        EndRequerenteLabel.Size = New System.Drawing.Size(63, 15)
        EndRequerenteLabel.TabIndex = 26
        EndRequerenteLabel.Text = "Endereço:"
        '
        'FoneRequerenteLabel
        '
        FoneRequerenteLabel.AutoSize = True
        FoneRequerenteLabel.Location = New System.Drawing.Point(8, 192)
        FoneRequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FoneRequerenteLabel.Name = "FoneRequerenteLabel"
        FoneRequerenteLabel.Size = New System.Drawing.Size(58, 15)
        FoneRequerenteLabel.TabIndex = 27
        FoneRequerenteLabel.Text = "Telefone:"
        '
        'EmailRequerenteLabel
        '
        EmailRequerenteLabel.AutoSize = True
        EmailRequerenteLabel.Location = New System.Drawing.Point(202, 192)
        EmailRequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailRequerenteLabel.Name = "EmailRequerenteLabel"
        EmailRequerenteLabel.Size = New System.Drawing.Size(45, 15)
        EmailRequerenteLabel.TabIndex = 28
        EmailRequerenteLabel.Text = "e-Mail:"
        '
        'CPFRequerenteLabel
        '
        CPFRequerenteLabel.AutoSize = True
        CPFRequerenteLabel.Location = New System.Drawing.Point(34, 58)
        CPFRequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CPFRequerenteLabel.Name = "CPFRequerenteLabel"
        CPFRequerenteLabel.Size = New System.Drawing.Size(33, 15)
        CPFRequerenteLabel.TabIndex = 31
        CPFRequerenteLabel.Text = "CPF:"
        '
        'RGRequerenteLabel
        '
        RGRequerenteLabel.AutoSize = True
        RGRequerenteLabel.Location = New System.Drawing.Point(180, 58)
        RGRequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RGRequerenteLabel.Name = "RGRequerenteLabel"
        RGRequerenteLabel.Size = New System.Drawing.Size(28, 15)
        RGRequerenteLabel.TabIndex = 32
        RGRequerenteLabel.Text = "RG:"
        '
        'CNPJRequerenteLabel
        '
        CNPJRequerenteLabel.AutoSize = True
        CNPJRequerenteLabel.Location = New System.Drawing.Point(26, 132)
        CNPJRequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CNPJRequerenteLabel.Name = "CNPJRequerenteLabel"
        CNPJRequerenteLabel.Size = New System.Drawing.Size(41, 15)
        CNPJRequerenteLabel.TabIndex = 33
        CNPJRequerenteLabel.Text = "CNPJ:"
        '
        'CNAELabel
        '
        CNAELabel.AutoSize = True
        CNAELabel.Location = New System.Drawing.Point(14, 18)
        CNAELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CNAELabel.Name = "CNAELabel"
        CNAELabel.Size = New System.Drawing.Size(39, 15)
        CNAELabel.TabIndex = 23
        CNAELabel.Text = "CNAE"
        '
        'RamodeatividadeLabel
        '
        RamodeatividadeLabel.AutoSize = True
        RamodeatividadeLabel.Location = New System.Drawing.Point(139, 18)
        RamodeatividadeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RamodeatividadeLabel.Name = "RamodeatividadeLabel"
        RamodeatividadeLabel.Size = New System.Drawing.Size(110, 15)
        RamodeatividadeLabel.TabIndex = 24
        RamodeatividadeLabel.Text = "Ramo de Atividade"
        '
        'ResptecnicoNumeroLabel
        '
        ResptecnicoNumeroLabel.AutoSize = True
        ResptecnicoNumeroLabel.Location = New System.Drawing.Point(40, 63)
        ResptecnicoNumeroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ResptecnicoNumeroLabel.Name = "ResptecnicoNumeroLabel"
        ResptecnicoNumeroLabel.Size = New System.Drawing.Size(69, 15)
        ResptecnicoNumeroLabel.TabIndex = 22
        ResptecnicoNumeroLabel.Text = "Nº Carteira:"
        '
        'ResptecnicoLabel
        '
        ResptecnicoLabel.AutoSize = True
        ResptecnicoLabel.Location = New System.Drawing.Point(18, 29)
        ResptecnicoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ResptecnicoLabel.Name = "ResptecnicoLabel"
        ResptecnicoLabel.Size = New System.Drawing.Size(88, 15)
        ResptecnicoLabel.TabIndex = 20
        ResptecnicoLabel.Text = "Resp. Técnico:"
        '
        'EndCidadeLabel
        '
        EndCidadeLabel.AutoSize = True
        EndCidadeLabel.Location = New System.Drawing.Point(40, 177)
        EndCidadeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndCidadeLabel.Name = "EndCidadeLabel"
        EndCidadeLabel.Size = New System.Drawing.Size(49, 15)
        EndCidadeLabel.TabIndex = 17
        EndCidadeLabel.Text = "Cidade:"
        '
        'EndEstadoLabel
        '
        EndEstadoLabel.AutoSize = True
        EndEstadoLabel.Location = New System.Drawing.Point(240, 177)
        EndEstadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndEstadoLabel.Name = "EndEstadoLabel"
        EndEstadoLabel.Size = New System.Drawing.Size(48, 15)
        EndEstadoLabel.TabIndex = 18
        EndEstadoLabel.Text = "Estado:"
        '
        'EndBairroLabel
        '
        EndBairroLabel.AutoSize = True
        EndBairroLabel.Location = New System.Drawing.Point(47, 147)
        EndBairroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndBairroLabel.Name = "EndBairroLabel"
        EndBairroLabel.Size = New System.Drawing.Size(43, 15)
        EndBairroLabel.TabIndex = 11
        EndBairroLabel.Text = "Bairro:"
        '
        'EndCompLabel
        '
        EndCompLabel.AutoSize = True
        EndCompLabel.Location = New System.Drawing.Point(175, 87)
        EndCompLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndCompLabel.Name = "EndCompLabel"
        EndCompLabel.Size = New System.Drawing.Size(88, 15)
        EndCompLabel.TabIndex = 9
        EndCompLabel.Text = "Complemento:"
        '
        'EndNumLabel
        '
        EndNumLabel.AutoSize = True
        EndNumLabel.Location = New System.Drawing.Point(64, 87)
        EndNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndNumLabel.Name = "EndNumLabel"
        EndNumLabel.Size = New System.Drawing.Size(23, 15)
        EndNumLabel.TabIndex = 7
        EndNumLabel.Text = "Nº:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(24, 57)
        EnderecoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(63, 15)
        EnderecoLabel.TabIndex = 5
        EnderecoLabel.Text = "Endereço:"
        '
        'EndCEPLabel
        '
        EndCEPLabel.AutoSize = True
        EndCEPLabel.Location = New System.Drawing.Point(54, 27)
        EndCEPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndCEPLabel.Name = "EndCEPLabel"
        EndCEPLabel.Size = New System.Drawing.Size(34, 15)
        EndCEPLabel.TabIndex = 13
        EndCEPLabel.Text = "CEP:"
        '
        'EndZonaLabel
        '
        EndZonaLabel.AutoSize = True
        EndZonaLabel.Location = New System.Drawing.Point(49, 117)
        EndZonaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndZonaLabel.Name = "EndZonaLabel"
        EndZonaLabel.Size = New System.Drawing.Size(38, 15)
        EndZonaLabel.TabIndex = 26
        EndZonaLabel.Text = "Zona:"
        '
        'EndQuadraLabel
        '
        EndQuadraLabel.AutoSize = True
        EndQuadraLabel.Location = New System.Drawing.Point(140, 117)
        EndQuadraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndQuadraLabel.Name = "EndQuadraLabel"
        EndQuadraLabel.Size = New System.Drawing.Size(51, 15)
        EndQuadraLabel.TabIndex = 27
        EndQuadraLabel.Text = "Quadra:"
        '
        'EndDataLabel
        '
        EndDataLabel.AutoSize = True
        EndDataLabel.Location = New System.Drawing.Point(234, 117)
        EndDataLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndDataLabel.Name = "EndDataLabel"
        EndDataLabel.Size = New System.Drawing.Size(36, 15)
        EndDataLabel.TabIndex = 28
        EndDataLabel.Text = "Data:"
        '
        'CadImobLabel
        '
        CadImobLabel.AutoSize = True
        CadImobLabel.Location = New System.Drawing.Point(323, 117)
        CadImobLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CadImobLabel.Name = "CadImobLabel"
        CadImobLabel.Size = New System.Drawing.Size(120, 15)
        CadImobLabel.TabIndex = 39
        CadImobLabel.Text = "Cadastro Imobiliário:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(24, 211)
        AreaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(117, 15)
        AreaLabel.TabIndex = 40
        AreaLabel.Text = "Área do Imóvel (m²):"
        '
        'Area2Label
        '
        Area2Label.AutoSize = True
        Area2Label.Location = New System.Drawing.Point(267, 211)
        Area2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Area2Label.Name = "Area2Label"
        Area2Label.Size = New System.Drawing.Size(173, 15)
        Area2Label.TabIndex = 41
        Area2Label.Text = "Área do Estabelecimento (m²):"
        '
        'PontoRefLabel
        '
        PontoRefLabel.AutoSize = True
        PontoRefLabel.Location = New System.Drawing.Point(274, 147)
        PontoRefLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PontoRefLabel.Name = "PontoRefLabel"
        PontoRefLabel.Size = New System.Drawing.Size(122, 15)
        PontoRefLabel.TabIndex = 51
        PontoRefLabel.Text = "Ponto de Referência:"
        '
        'NaturezaDoPedidoOBSLabel
        '
        NaturezaDoPedidoOBSLabel.AutoSize = True
        NaturezaDoPedidoOBSLabel.Location = New System.Drawing.Point(16, 22)
        NaturezaDoPedidoOBSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NaturezaDoPedidoOBSLabel.Name = "NaturezaDoPedidoOBSLabel"
        NaturezaDoPedidoOBSLabel.Size = New System.Drawing.Size(207, 15)
        NaturezaDoPedidoOBSLabel.TabIndex = 29
        NaturezaDoPedidoOBSLabel.Text = "Observação para colocar no LAUDO:"
        '
        'ProtocoloTipoLabel
        '
        ProtocoloTipoLabel.AutoSize = True
        ProtocoloTipoLabel.Location = New System.Drawing.Point(13, 95)
        ProtocoloTipoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProtocoloTipoLabel.Name = "ProtocoloTipoLabel"
        ProtocoloTipoLabel.Size = New System.Drawing.Size(34, 15)
        ProtocoloTipoLabel.TabIndex = 71
        ProtocoloTipoLabel.Text = "Tipo:"
        '
        'ProtocoloNLabel
        '
        ProtocoloNLabel.AutoSize = True
        ProtocoloNLabel.Location = New System.Drawing.Point(108, 95)
        ProtocoloNLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProtocoloNLabel.Name = "ProtocoloNLabel"
        ProtocoloNLabel.Size = New System.Drawing.Size(23, 15)
        ProtocoloNLabel.TabIndex = 72
        ProtocoloNLabel.Text = "Nº:"
        '
        'ProtocoloAnoLabel
        '
        ProtocoloAnoLabel.AutoSize = True
        ProtocoloAnoLabel.Location = New System.Drawing.Point(246, 95)
        ProtocoloAnoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProtocoloAnoLabel.Name = "ProtocoloAnoLabel"
        ProtocoloAnoLabel.Size = New System.Drawing.Size(31, 15)
        ProtocoloAnoLabel.TabIndex = 73
        ProtocoloAnoLabel.Text = "Ano:"
        '
        'ProtocoloSenhaLabel
        '
        ProtocoloSenhaLabel.AutoSize = True
        ProtocoloSenhaLabel.Location = New System.Drawing.Point(365, 95)
        ProtocoloSenhaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProtocoloSenhaLabel.Name = "ProtocoloSenhaLabel"
        ProtocoloSenhaLabel.Size = New System.Drawing.Size(46, 15)
        ProtocoloSenhaLabel.TabIndex = 74
        ProtocoloSenhaLabel.Text = "Senha:"
        '
        'HistoricoLabel
        '
        HistoricoLabel.AutoSize = True
        HistoricoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HistoricoLabel.Location = New System.Drawing.Point(9, 12)
        HistoricoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HistoricoLabel.Name = "HistoricoLabel"
        HistoricoLabel.Size = New System.Drawing.Size(85, 20)
        HistoricoLabel.TabIndex = 0
        HistoricoLabel.Text = "Histórico:"
        '
        'BombeiroSituacaoLabel
        '
        BombeiroSituacaoLabel.AutoSize = True
        BombeiroSituacaoLabel.Location = New System.Drawing.Point(5, 118)
        BombeiroSituacaoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BombeiroSituacaoLabel.Name = "BombeiroSituacaoLabel"
        BombeiroSituacaoLabel.Size = New System.Drawing.Size(115, 15)
        BombeiroSituacaoLabel.TabIndex = 75
        BombeiroSituacaoLabel.Text = "Situação Bombeiro:"
        '
        'EndCidadeLabel1
        '
        EndCidadeLabel1.AutoSize = True
        EndCidadeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndCidadeLabel1.Location = New System.Drawing.Point(329, 134)
        EndCidadeLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndCidadeLabel1.Name = "EndCidadeLabel1"
        EndCidadeLabel1.Size = New System.Drawing.Size(54, 16)
        EndCidadeLabel1.TabIndex = 75
        EndCidadeLabel1.Text = "Cidade:"
        '
        'EndEstadoLabel1
        '
        EndEstadoLabel1.AutoSize = True
        EndEstadoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndEstadoLabel1.Location = New System.Drawing.Point(329, 158)
        EndEstadoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EndEstadoLabel1.Name = "EndEstadoLabel1"
        EndEstadoLabel1.Size = New System.Drawing.Size(53, 16)
        EndEstadoLabel1.TabIndex = 76
        EndEstadoLabel1.Text = "Estado:"
        '
        'OrgaoRGRequerenteLabel
        '
        OrgaoRGRequerenteLabel.AutoSize = True
        OrgaoRGRequerenteLabel.Location = New System.Drawing.Point(315, 58)
        OrgaoRGRequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OrgaoRGRequerenteLabel.Name = "OrgaoRGRequerenteLabel"
        OrgaoRGRequerenteLabel.Size = New System.Drawing.Size(44, 15)
        OrgaoRGRequerenteLabel.TabIndex = 57
        OrgaoRGRequerenteLabel.Text = "Orgão:"
        '
        'EstadoOrgaoRGRequerenteLabel
        '
        EstadoOrgaoRGRequerenteLabel.AutoSize = True
        EstadoOrgaoRGRequerenteLabel.Location = New System.Drawing.Point(428, 58)
        EstadoOrgaoRGRequerenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EstadoOrgaoRGRequerenteLabel.Name = "EstadoOrgaoRGRequerenteLabel"
        EstadoOrgaoRGRequerenteLabel.Size = New System.Drawing.Size(48, 15)
        EstadoOrgaoRGRequerenteLabel.TabIndex = 58
        EstadoOrgaoRGRequerenteLabel.Text = "Estado:"
        '
        'NumeroProcessoLabel
        '
        NumeroProcessoLabel.AutoSize = True
        NumeroProcessoLabel.Location = New System.Drawing.Point(18, 165)
        NumeroProcessoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumeroProcessoLabel.Name = "NumeroProcessoLabel"
        NumeroProcessoLabel.Size = New System.Drawing.Size(126, 15)
        NumeroProcessoLabel.TabIndex = 0
        NumeroProcessoLabel.Text = "Número do Processo:"
        '
        'ReciboProcessoLabel
        '
        ReciboProcessoLabel.AutoSize = True
        ReciboProcessoLabel.Location = New System.Drawing.Point(23, 195)
        ReciboProcessoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ReciboProcessoLabel.Name = "ReciboProcessoLabel"
        ReciboProcessoLabel.Size = New System.Drawing.Size(114, 15)
        ReciboProcessoLabel.TabIndex = 2
        ReciboProcessoLabel.Text = "Número do Recibo:"
        '
        'MatrizLabel
        '
        MatrizLabel.AutoSize = True
        MatrizLabel.Location = New System.Drawing.Point(547, 79)
        MatrizLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MatrizLabel.Name = "MatrizLabel"
        MatrizLabel.Size = New System.Drawing.Size(43, 15)
        MatrizLabel.TabIndex = 57
        MatrizLabel.Text = "SEDE:"
        '
        'NlaudoSecundarioLabel
        '
        NlaudoSecundarioLabel.AutoSize = True
        NlaudoSecundarioLabel.Location = New System.Drawing.Point(23, 57)
        NlaudoSecundarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NlaudoSecundarioLabel.Name = "NlaudoSecundarioLabel"
        NlaudoSecundarioLabel.Size = New System.Drawing.Size(92, 15)
        NlaudoSecundarioLabel.TabIndex = 57
        NlaudoSecundarioLabel.Text = "2º Nº do Laudo:"
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LaudosBindingSource
        '
        Me.LaudosBindingSource.DataMember = "Laudos"
        Me.LaudosBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'LaudosTableAdapter
        '
        Me.LaudosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.EventosEmpresaTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Me.LaudosTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LaudosBindingNavigator
        '
        Me.LaudosBindingNavigator.AddNewItem = Nothing
        Me.LaudosBindingNavigator.BackColor = System.Drawing.Color.Silver
        Me.LaudosBindingNavigator.BindingSource = Me.LaudosBindingSource
        Me.LaudosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LaudosBindingNavigator.DeleteItem = Nothing
        Me.LaudosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.LaudosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LaudosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LaudosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LaudosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LaudosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LaudosBindingNavigator.Name = "LaudosBindingNavigator"
        Me.LaudosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LaudosBindingNavigator.Size = New System.Drawing.Size(1011, 25)
        Me.LaudosBindingNavigator.TabIndex = 0
        Me.LaudosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(28, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(90, 44)
        Me.RazaoSocialTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(502, 21)
        Me.RazaoSocialTextBox.TabIndex = 2
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(90, 74)
        Me.CNPJMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CNPJMaskedTextBox.Mask = "99,999,999/9999-99"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(129, 21)
        Me.CNPJMaskedTextBox.TabIndex = 4
        '
        'BombeirosCheckBox
        '
        Me.BombeirosCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LaudosBindingSource, "Bombeiros", True))
        Me.BombeirosCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombeirosCheckBox.Location = New System.Drawing.Point(10, 16)
        Me.BombeirosCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BombeirosCheckBox.Name = "BombeirosCheckBox"
        Me.BombeirosCheckBox.Size = New System.Drawing.Size(91, 28)
        Me.BombeirosCheckBox.TabIndex = 6
        Me.BombeirosCheckBox.Text = "Bombeiros"
        Me.BombeirosCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.SetranSituacaoComboBox)
        Me.GroupBox1.Controls.Add(Me.SanitarioSituacaoComboBox)
        Me.GroupBox1.Controls.Add(Me.ViabilidadeSituacaoComboBox)
        Me.GroupBox1.Controls.Add(Me.AmbientalSituacaoComboBox)
        Me.GroupBox1.Controls.Add(BombeirosSituacaoLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(291, 233)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REQUERIMENTOS - SITUAÇÃO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(2, 198)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 15)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "Setran"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 165)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 15)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "Sanitário"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 132)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 15)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Viabilidade"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 97)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 15)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Ambiental"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 62)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Bombeiro"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(247, 55)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 25)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(247, 193)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(41, 25)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Ver"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(247, 159)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 25)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Ver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(247, 126)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 25)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Ver"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(247, 91)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 25)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Ver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SetranSituacaoComboBox
        '
        Me.SetranSituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "SetranSituacao", True))
        Me.SetranSituacaoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetranSituacaoComboBox.FormattingEnabled = True
        Me.SetranSituacaoComboBox.Items.AddRange(New Object() {"Não Iniciado", "Aguardando Pagamento", "Encaminhado p/ Vistoria", "Em Andamento", "Em Exigências", "Liberado", "-"})
        Me.SetranSituacaoComboBox.Location = New System.Drawing.Point(68, 195)
        Me.SetranSituacaoComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SetranSituacaoComboBox.Name = "SetranSituacaoComboBox"
        Me.SetranSituacaoComboBox.Size = New System.Drawing.Size(172, 23)
        Me.SetranSituacaoComboBox.TabIndex = 20
        '
        'SanitarioSituacaoComboBox
        '
        Me.SanitarioSituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "SanitarioSituacao", True))
        Me.SanitarioSituacaoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanitarioSituacaoComboBox.FormattingEnabled = True
        Me.SanitarioSituacaoComboBox.Items.AddRange(New Object() {"Não Iniciado", "Aguardando Pagamento", "Encaminhado p/ Vistoria", "Em Andamento", "Em Exigências", "Liberado", "-"})
        Me.SanitarioSituacaoComboBox.Location = New System.Drawing.Point(68, 160)
        Me.SanitarioSituacaoComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SanitarioSituacaoComboBox.Name = "SanitarioSituacaoComboBox"
        Me.SanitarioSituacaoComboBox.Size = New System.Drawing.Size(172, 23)
        Me.SanitarioSituacaoComboBox.TabIndex = 17
        '
        'ViabilidadeSituacaoComboBox
        '
        Me.ViabilidadeSituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ViabilidadeSituacao", True))
        Me.ViabilidadeSituacaoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViabilidadeSituacaoComboBox.FormattingEnabled = True
        Me.ViabilidadeSituacaoComboBox.Items.AddRange(New Object() {"Não Iniciado", "Aguardando Pagamento", "Encaminhado p/ Vistoria", "Em Andamento", "Em Exigências", "Liberado", "-"})
        Me.ViabilidadeSituacaoComboBox.Location = New System.Drawing.Point(68, 126)
        Me.ViabilidadeSituacaoComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ViabilidadeSituacaoComboBox.Name = "ViabilidadeSituacaoComboBox"
        Me.ViabilidadeSituacaoComboBox.Size = New System.Drawing.Size(172, 23)
        Me.ViabilidadeSituacaoComboBox.TabIndex = 14
        '
        'AmbientalSituacaoComboBox
        '
        Me.AmbientalSituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "AmbientalSituacao", True))
        Me.AmbientalSituacaoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbientalSituacaoComboBox.FormattingEnabled = True
        Me.AmbientalSituacaoComboBox.Items.AddRange(New Object() {"Não Iniciado", "Aguardando Pagamento", "Encaminhado p/ Vistoria", "Em Andamento", "Em Exigências", "Liberado", "-"})
        Me.AmbientalSituacaoComboBox.Location = New System.Drawing.Point(68, 91)
        Me.AmbientalSituacaoComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AmbientalSituacaoComboBox.Name = "AmbientalSituacaoComboBox"
        Me.AmbientalSituacaoComboBox.Size = New System.Drawing.Size(172, 23)
        Me.AmbientalSituacaoComboBox.TabIndex = 11
        '
        'SetranCheckBox
        '
        Me.SetranCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LaudosBindingSource, "Setran", True))
        Me.SetranCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetranCheckBox.Location = New System.Drawing.Point(355, 16)
        Me.SetranCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SetranCheckBox.Name = "SetranCheckBox"
        Me.SetranCheckBox.Size = New System.Drawing.Size(68, 28)
        Me.SetranCheckBox.TabIndex = 19
        Me.SetranCheckBox.Text = "Setran"
        Me.SetranCheckBox.UseVisualStyleBackColor = True
        '
        'SanitarioCheckBox
        '
        Me.SanitarioCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LaudosBindingSource, "Sanitario", True))
        Me.SanitarioCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanitarioCheckBox.Location = New System.Drawing.Point(276, 16)
        Me.SanitarioCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SanitarioCheckBox.Name = "SanitarioCheckBox"
        Me.SanitarioCheckBox.Size = New System.Drawing.Size(78, 28)
        Me.SanitarioCheckBox.TabIndex = 16
        Me.SanitarioCheckBox.Text = "Sanitário"
        Me.SanitarioCheckBox.UseVisualStyleBackColor = True
        '
        'ViabilidadeCheckBox
        '
        Me.ViabilidadeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LaudosBindingSource, "Viabilidade", True))
        Me.ViabilidadeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViabilidadeCheckBox.Location = New System.Drawing.Point(187, 16)
        Me.ViabilidadeCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ViabilidadeCheckBox.Name = "ViabilidadeCheckBox"
        Me.ViabilidadeCheckBox.Size = New System.Drawing.Size(81, 28)
        Me.ViabilidadeCheckBox.TabIndex = 13
        Me.ViabilidadeCheckBox.Text = "Viabilidade"
        Me.ViabilidadeCheckBox.UseVisualStyleBackColor = True
        '
        'AmbientalCheckBox
        '
        Me.AmbientalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LaudosBindingSource, "Ambiental", True))
        Me.AmbientalCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbientalCheckBox.Location = New System.Drawing.Point(102, 16)
        Me.AmbientalCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AmbientalCheckBox.Name = "AmbientalCheckBox"
        Me.AmbientalCheckBox.Size = New System.Drawing.Size(85, 28)
        Me.AmbientalCheckBox.TabIndex = 10
        Me.AmbientalCheckBox.Text = "Ambiental"
        Me.AmbientalCheckBox.UseVisualStyleBackColor = True
        '
        'TabControlAcompanhamento
        '
        Me.TabControlAcompanhamento.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControlAcompanhamento.Controls.Add(Me.TabPage1)
        Me.TabControlAcompanhamento.Controls.Add(Me.TabPage2)
        Me.TabControlAcompanhamento.Controls.Add(Me.TabPage3)
        Me.TabControlAcompanhamento.Controls.Add(Me.TabPage4)
        Me.TabControlAcompanhamento.Controls.Add(Me.TabPage5)
        Me.TabControlAcompanhamento.Location = New System.Drawing.Point(294, 9)
        Me.TabControlAcompanhamento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControlAcompanhamento.Name = "TabControlAcompanhamento"
        Me.TabControlAcompanhamento.SelectedIndex = 0
        Me.TabControlAcompanhamento.Size = New System.Drawing.Size(597, 238)
        Me.TabControlAcompanhamento.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GroupBoxDatProvBombeiro)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.BombeiroExigenciaRichTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Size = New System.Drawing.Size(589, 207)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bombeiros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBoxDatProvBombeiro
        '
        Me.GroupBoxDatProvBombeiro.Controls.Add(Me.ButtonApagaDataBombeiro)
        Me.GroupBoxDatProvBombeiro.Controls.Add(Me.BombeiroProvisorioDATAMaskedTextBox)
        Me.GroupBoxDatProvBombeiro.Controls.Add(Me.ButtonAddDataBombeiro)
        Me.GroupBoxDatProvBombeiro.Location = New System.Drawing.Point(6, 144)
        Me.GroupBoxDatProvBombeiro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvBombeiro.Name = "GroupBoxDatProvBombeiro"
        Me.GroupBoxDatProvBombeiro.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvBombeiro.Size = New System.Drawing.Size(166, 53)
        Me.GroupBoxDatProvBombeiro.TabIndex = 18
        Me.GroupBoxDatProvBombeiro.TabStop = False
        Me.GroupBoxDatProvBombeiro.Text = "Vencimento Provisório:"
        '
        'ButtonApagaDataBombeiro
        '
        Me.ButtonApagaDataBombeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonApagaDataBombeiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonApagaDataBombeiro.Image = Global.PrinceSistemas.My.Resources.Resources.lixeira
        Me.ButtonApagaDataBombeiro.Location = New System.Drawing.Point(121, 18)
        Me.ButtonApagaDataBombeiro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonApagaDataBombeiro.Name = "ButtonApagaDataBombeiro"
        Me.ButtonApagaDataBombeiro.Size = New System.Drawing.Size(33, 27)
        Me.ButtonApagaDataBombeiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonApagaDataBombeiro.TabIndex = 15
        Me.ButtonApagaDataBombeiro.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonApagaDataBombeiro, "Excluir e Limpar")
        '
        'BombeiroProvisorioDATAMaskedTextBox
        '
        Me.BombeiroProvisorioDATAMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "BombeiroProvisorioDATA", True))
        Me.BombeiroProvisorioDATAMaskedTextBox.Location = New System.Drawing.Point(7, 22)
        Me.BombeiroProvisorioDATAMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BombeiroProvisorioDATAMaskedTextBox.Mask = "00/00/0000"
        Me.BombeiroProvisorioDATAMaskedTextBox.Name = "BombeiroProvisorioDATAMaskedTextBox"
        Me.BombeiroProvisorioDATAMaskedTextBox.Size = New System.Drawing.Size(76, 21)
        Me.BombeiroProvisorioDATAMaskedTextBox.TabIndex = 14
        Me.BombeiroProvisorioDATAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonAddDataBombeiro
        '
        Me.ButtonAddDataBombeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAddDataBombeiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddDataBombeiro.Image = Global.PrinceSistemas.My.Resources.Resources.adicionar
        Me.ButtonAddDataBombeiro.Location = New System.Drawing.Point(91, 18)
        Me.ButtonAddDataBombeiro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAddDataBombeiro.Name = "ButtonAddDataBombeiro"
        Me.ButtonAddDataBombeiro.Size = New System.Drawing.Size(29, 27)
        Me.ButtonAddDataBombeiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonAddDataBombeiro.TabIndex = 17
        Me.ButtonAddDataBombeiro.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonAddDataBombeiro, "Adicionar / Alterar")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelBombeiroMulta)
        Me.GroupBox2.Controls.Add(Me.BombeiroDataMultaMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.BtnMultaBombeiro)
        Me.GroupBox2.Controls.Add(Me.Button27)
        Me.GroupBox2.Controls.Add(Me.BtnProcotBomb)
        Me.GroupBox2.Controls.Add(Me.Button26)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.BombeiroNProcessoMaskedTextBox)
        Me.GroupBox2.Controls.Add(BombeiroNProcessoLabel)
        Me.GroupBox2.Controls.Add(Me.BombeiroDataPedProcessoMaskedTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(321, 186)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Corpo de Bombeiros ( PrevFogo )"
        '
        'LabelBombeiroMulta
        '
        Me.LabelBombeiroMulta.AutoSize = True
        Me.LabelBombeiroMulta.Location = New System.Drawing.Point(182, 88)
        Me.LabelBombeiroMulta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBombeiroMulta.Name = "LabelBombeiroMulta"
        Me.LabelBombeiroMulta.Size = New System.Drawing.Size(87, 15)
        Me.LabelBombeiroMulta.TabIndex = 82
        Me.LabelBombeiroMulta.Text = "Prazo Máximo"
        '
        'BombeiroDataMultaMaskedTextBox
        '
        Me.BombeiroDataMultaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "BombeiroDataMulta", True))
        Me.BombeiroDataMultaMaskedTextBox.Location = New System.Drawing.Point(100, 82)
        Me.BombeiroDataMultaMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BombeiroDataMultaMaskedTextBox.Mask = "00/00/0000"
        Me.BombeiroDataMultaMaskedTextBox.Name = "BombeiroDataMultaMaskedTextBox"
        Me.BombeiroDataMultaMaskedTextBox.Size = New System.Drawing.Size(79, 21)
        Me.BombeiroDataMultaMaskedTextBox.TabIndex = 19
        Me.BombeiroDataMultaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'BtnMultaBombeiro
        '
        Me.BtnMultaBombeiro.BackgroundImage = CType(resources.GetObject("BtnMultaBombeiro.BackgroundImage"), System.Drawing.Image)
        Me.BtnMultaBombeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMultaBombeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMultaBombeiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMultaBombeiro.Location = New System.Drawing.Point(6, 80)
        Me.BtnMultaBombeiro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnMultaBombeiro.Name = "BtnMultaBombeiro"
        Me.BtnMultaBombeiro.Size = New System.Drawing.Size(90, 27)
        Me.BtnMultaBombeiro.TabIndex = 48
        Me.BtnMultaBombeiro.Text = "Teve Multa?"
        Me.BtnMultaBombeiro.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.Transparent
        Me.Button27.BackgroundImage = CType(resources.GetObject("Button27.BackgroundImage"), System.Drawing.Image)
        Me.Button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Location = New System.Drawing.Point(262, 21)
        Me.Button27.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(54, 25)
        Me.Button27.TabIndex = 81
        Me.Button27.Text = "Copiar"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'BtnProcotBomb
        '
        Me.BtnProcotBomb.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnProcotBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnProcotBomb.Location = New System.Drawing.Point(12, 118)
        Me.BtnProcotBomb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnProcotBomb.Name = "BtnProcotBomb"
        Me.BtnProcotBomb.Size = New System.Drawing.Size(144, 27)
        Me.BtnProcotBomb.TabIndex = 79
        Me.BtnProcotBomb.Text = "Novo Protocolo"
        Me.BtnProcotBomb.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button26.Location = New System.Drawing.Point(187, 52)
        Me.Button26.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(50, 24)
        Me.Button26.TabIndex = 80
        Me.Button26.Text = "Agora"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Location = New System.Drawing.Point(12, 151)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(144, 27)
        Me.Button11.TabIndex = 52
        Me.Button11.Text = "Acompanhar Processo"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Solicitado dia:"
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(166, 151)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(102, 27)
        Me.Button9.TabIndex = 50
        Me.Button9.Text = "Site Bombeiros"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'BombeiroNProcessoMaskedTextBox
        '
        Me.BombeiroNProcessoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "BombeiroNProcesso", True))
        Me.BombeiroNProcessoMaskedTextBox.Location = New System.Drawing.Point(98, 22)
        Me.BombeiroNProcessoMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BombeiroNProcessoMaskedTextBox.Mask = "9,9,99,99,9999999999-99"
        Me.BombeiroNProcessoMaskedTextBox.Name = "BombeiroNProcessoMaskedTextBox"
        Me.BombeiroNProcessoMaskedTextBox.Size = New System.Drawing.Size(158, 21)
        Me.BombeiroNProcessoMaskedTextBox.TabIndex = 4
        '
        'BombeiroDataPedProcessoMaskedTextBox
        '
        Me.BombeiroDataPedProcessoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "BombeiroDataPedProcesso", True))
        Me.BombeiroDataPedProcessoMaskedTextBox.Location = New System.Drawing.Point(99, 52)
        Me.BombeiroDataPedProcessoMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BombeiroDataPedProcessoMaskedTextBox.Mask = "00/00/0000"
        Me.BombeiroDataPedProcessoMaskedTextBox.Name = "BombeiroDataPedProcessoMaskedTextBox"
        Me.BombeiroDataPedProcessoMaskedTextBox.Size = New System.Drawing.Size(80, 21)
        Me.BombeiroDataPedProcessoMaskedTextBox.TabIndex = 6
        Me.BombeiroDataPedProcessoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'BombeiroExigenciaRichTextBox
        '
        Me.BombeiroExigenciaRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "BombeiroExigencia", True))
        Me.BombeiroExigenciaRichTextBox.Location = New System.Drawing.Point(6, 33)
        Me.BombeiroExigenciaRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BombeiroExigenciaRichTextBox.Name = "BombeiroExigenciaRichTextBox"
        Me.BombeiroExigenciaRichTextBox.Size = New System.Drawing.Size(255, 101)
        Me.BombeiroExigenciaRichTextBox.TabIndex = 1
        Me.BombeiroExigenciaRichTextBox.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.GroupBoxDatProvAmbiental)
        Me.TabPage2.Controls.Add(Me.AmbientalExigenciaRichTextBox)
        Me.TabPage2.Controls.Add(AmbientalDataProvisorioLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Size = New System.Drawing.Size(589, 207)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ambiental"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBoxDatProvAmbiental
        '
        Me.GroupBoxDatProvAmbiental.Controls.Add(Me.AmbientalProvisorioDATAMaskedTextBox)
        Me.GroupBoxDatProvAmbiental.Controls.Add(Me.ButtonAddDataAmbiental)
        Me.GroupBoxDatProvAmbiental.Controls.Add(Me.ButtonApagaDataAmbiental)
        Me.GroupBoxDatProvAmbiental.Location = New System.Drawing.Point(16, 144)
        Me.GroupBoxDatProvAmbiental.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvAmbiental.Name = "GroupBoxDatProvAmbiental"
        Me.GroupBoxDatProvAmbiental.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvAmbiental.Size = New System.Drawing.Size(166, 53)
        Me.GroupBoxDatProvAmbiental.TabIndex = 20
        Me.GroupBoxDatProvAmbiental.TabStop = False
        Me.GroupBoxDatProvAmbiental.Text = "Vencimento Provisório:"
        '
        'AmbientalProvisorioDATAMaskedTextBox
        '
        Me.AmbientalProvisorioDATAMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "AmbientalProvisorioDATA", True))
        Me.AmbientalProvisorioDATAMaskedTextBox.Location = New System.Drawing.Point(7, 22)
        Me.AmbientalProvisorioDATAMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AmbientalProvisorioDATAMaskedTextBox.Mask = "00/00/0000"
        Me.AmbientalProvisorioDATAMaskedTextBox.Name = "AmbientalProvisorioDATAMaskedTextBox"
        Me.AmbientalProvisorioDATAMaskedTextBox.Size = New System.Drawing.Size(76, 21)
        Me.AmbientalProvisorioDATAMaskedTextBox.TabIndex = 4
        Me.AmbientalProvisorioDATAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonAddDataAmbiental
        '
        Me.ButtonAddDataAmbiental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAddDataAmbiental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddDataAmbiental.Image = Global.PrinceSistemas.My.Resources.Resources.adicionar
        Me.ButtonAddDataAmbiental.Location = New System.Drawing.Point(91, 18)
        Me.ButtonAddDataAmbiental.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAddDataAmbiental.Name = "ButtonAddDataAmbiental"
        Me.ButtonAddDataAmbiental.Size = New System.Drawing.Size(29, 27)
        Me.ButtonAddDataAmbiental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonAddDataAmbiental.TabIndex = 19
        Me.ButtonAddDataAmbiental.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonAddDataAmbiental, "Adicionar / Alterar")
        '
        'ButtonApagaDataAmbiental
        '
        Me.ButtonApagaDataAmbiental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonApagaDataAmbiental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonApagaDataAmbiental.Image = Global.PrinceSistemas.My.Resources.Resources.lixeira
        Me.ButtonApagaDataAmbiental.Location = New System.Drawing.Point(121, 18)
        Me.ButtonApagaDataAmbiental.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonApagaDataAmbiental.Name = "ButtonApagaDataAmbiental"
        Me.ButtonApagaDataAmbiental.Size = New System.Drawing.Size(33, 27)
        Me.ButtonApagaDataAmbiental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonApagaDataAmbiental.TabIndex = 16
        Me.ButtonApagaDataAmbiental.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonApagaDataAmbiental, "Excluir e Limpar")
        '
        'AmbientalExigenciaRichTextBox
        '
        Me.AmbientalExigenciaRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "AmbientalExigencia", True))
        Me.AmbientalExigenciaRichTextBox.Location = New System.Drawing.Point(16, 33)
        Me.AmbientalExigenciaRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AmbientalExigenciaRichTextBox.Name = "AmbientalExigenciaRichTextBox"
        Me.AmbientalExigenciaRichTextBox.Size = New System.Drawing.Size(311, 101)
        Me.AmbientalExigenciaRichTextBox.TabIndex = 2
        Me.AmbientalExigenciaRichTextBox.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.GroupBoxDatProvViabilidade)
        Me.TabPage3.Controls.Add(ViabilidadeExigenciaLabel)
        Me.TabPage3.Controls.Add(Me.ViabilidadeExigenciaRichTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(589, 207)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Viabilidade"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBoxDatProvViabilidade
        '
        Me.GroupBoxDatProvViabilidade.Controls.Add(Me.ViabilidadeProvisorioDATAMaskedTextBox)
        Me.GroupBoxDatProvViabilidade.Controls.Add(Me.ButtonAddDataViabilidade)
        Me.GroupBoxDatProvViabilidade.Controls.Add(Me.ButtonApagaDataViabilidade)
        Me.GroupBoxDatProvViabilidade.Location = New System.Drawing.Point(16, 144)
        Me.GroupBoxDatProvViabilidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvViabilidade.Name = "GroupBoxDatProvViabilidade"
        Me.GroupBoxDatProvViabilidade.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvViabilidade.Size = New System.Drawing.Size(166, 53)
        Me.GroupBoxDatProvViabilidade.TabIndex = 21
        Me.GroupBoxDatProvViabilidade.TabStop = False
        Me.GroupBoxDatProvViabilidade.Text = "Vencimento Provisório:"
        '
        'ViabilidadeProvisorioDATAMaskedTextBox
        '
        Me.ViabilidadeProvisorioDATAMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ViabilidadeProvisorioDATA", True))
        Me.ViabilidadeProvisorioDATAMaskedTextBox.Location = New System.Drawing.Point(7, 22)
        Me.ViabilidadeProvisorioDATAMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ViabilidadeProvisorioDATAMaskedTextBox.Mask = "00/00/0000"
        Me.ViabilidadeProvisorioDATAMaskedTextBox.Name = "ViabilidadeProvisorioDATAMaskedTextBox"
        Me.ViabilidadeProvisorioDATAMaskedTextBox.Size = New System.Drawing.Size(76, 21)
        Me.ViabilidadeProvisorioDATAMaskedTextBox.TabIndex = 4
        Me.ViabilidadeProvisorioDATAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonAddDataViabilidade
        '
        Me.ButtonAddDataViabilidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAddDataViabilidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddDataViabilidade.Image = Global.PrinceSistemas.My.Resources.Resources.adicionar
        Me.ButtonAddDataViabilidade.Location = New System.Drawing.Point(91, 18)
        Me.ButtonAddDataViabilidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAddDataViabilidade.Name = "ButtonAddDataViabilidade"
        Me.ButtonAddDataViabilidade.Size = New System.Drawing.Size(29, 27)
        Me.ButtonAddDataViabilidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonAddDataViabilidade.TabIndex = 18
        Me.ButtonAddDataViabilidade.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonAddDataViabilidade, "Adicionar / Alterar")
        '
        'ButtonApagaDataViabilidade
        '
        Me.ButtonApagaDataViabilidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonApagaDataViabilidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonApagaDataViabilidade.Image = Global.PrinceSistemas.My.Resources.Resources.lixeira
        Me.ButtonApagaDataViabilidade.Location = New System.Drawing.Point(121, 18)
        Me.ButtonApagaDataViabilidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonApagaDataViabilidade.Name = "ButtonApagaDataViabilidade"
        Me.ButtonApagaDataViabilidade.Size = New System.Drawing.Size(33, 27)
        Me.ButtonApagaDataViabilidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonApagaDataViabilidade.TabIndex = 16
        Me.ButtonApagaDataViabilidade.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonApagaDataViabilidade, "Excluir e Limpar")
        '
        'ViabilidadeExigenciaRichTextBox
        '
        Me.ViabilidadeExigenciaRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ViabilidadeExigencia", True))
        Me.ViabilidadeExigenciaRichTextBox.Location = New System.Drawing.Point(16, 33)
        Me.ViabilidadeExigenciaRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ViabilidadeExigenciaRichTextBox.Name = "ViabilidadeExigenciaRichTextBox"
        Me.ViabilidadeExigenciaRichTextBox.Size = New System.Drawing.Size(311, 101)
        Me.ViabilidadeExigenciaRichTextBox.TabIndex = 1
        Me.ViabilidadeExigenciaRichTextBox.Text = ""
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.GroupBoxDatProvSanitario)
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Controls.Add(SanitarioExigenciaLabel)
        Me.TabPage4.Controls.Add(Me.SanitarioExigenciaRichTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(589, 207)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Sanitário"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBoxDatProvSanitario
        '
        Me.GroupBoxDatProvSanitario.Controls.Add(Me.SanitarioProvisorioDATAMaskedTextBox)
        Me.GroupBoxDatProvSanitario.Controls.Add(Me.ButtonAddDataSanitario)
        Me.GroupBoxDatProvSanitario.Controls.Add(Me.ButtonApagaDataSanitario)
        Me.GroupBoxDatProvSanitario.Location = New System.Drawing.Point(16, 144)
        Me.GroupBoxDatProvSanitario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvSanitario.Name = "GroupBoxDatProvSanitario"
        Me.GroupBoxDatProvSanitario.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvSanitario.Size = New System.Drawing.Size(166, 53)
        Me.GroupBoxDatProvSanitario.TabIndex = 22
        Me.GroupBoxDatProvSanitario.TabStop = False
        Me.GroupBoxDatProvSanitario.Text = "Vencimento Provisório:"
        '
        'SanitarioProvisorioDATAMaskedTextBox
        '
        Me.SanitarioProvisorioDATAMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "SanitarioProvisorioDATA", True))
        Me.SanitarioProvisorioDATAMaskedTextBox.Location = New System.Drawing.Point(7, 22)
        Me.SanitarioProvisorioDATAMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SanitarioProvisorioDATAMaskedTextBox.Mask = "00/00/0000"
        Me.SanitarioProvisorioDATAMaskedTextBox.Name = "SanitarioProvisorioDATAMaskedTextBox"
        Me.SanitarioProvisorioDATAMaskedTextBox.Size = New System.Drawing.Size(76, 21)
        Me.SanitarioProvisorioDATAMaskedTextBox.TabIndex = 4
        Me.SanitarioProvisorioDATAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonAddDataSanitario
        '
        Me.ButtonAddDataSanitario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAddDataSanitario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddDataSanitario.Image = Global.PrinceSistemas.My.Resources.Resources.adicionar
        Me.ButtonAddDataSanitario.Location = New System.Drawing.Point(91, 18)
        Me.ButtonAddDataSanitario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAddDataSanitario.Name = "ButtonAddDataSanitario"
        Me.ButtonAddDataSanitario.Size = New System.Drawing.Size(29, 27)
        Me.ButtonAddDataSanitario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonAddDataSanitario.TabIndex = 18
        Me.ButtonAddDataSanitario.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonAddDataSanitario, "Adicionar / Alterar")
        '
        'ButtonApagaDataSanitario
        '
        Me.ButtonApagaDataSanitario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonApagaDataSanitario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonApagaDataSanitario.Image = Global.PrinceSistemas.My.Resources.Resources.lixeira
        Me.ButtonApagaDataSanitario.Location = New System.Drawing.Point(121, 18)
        Me.ButtonApagaDataSanitario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonApagaDataSanitario.Name = "ButtonApagaDataSanitario"
        Me.ButtonApagaDataSanitario.Size = New System.Drawing.Size(33, 27)
        Me.ButtonApagaDataSanitario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonApagaDataSanitario.TabIndex = 16
        Me.ButtonApagaDataSanitario.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonApagaDataSanitario, "Excluir e Limpar")
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button20)
        Me.GroupBox6.Controls.Add(Me.Sanitariocontrole3TextBox)
        Me.GroupBox6.Controls.Add(Me.Sanitariocontrole2TextBox)
        Me.GroupBox6.Controls.Add(Me.Sanitariocontrole1TextBox)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(335, 21)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox6.Size = New System.Drawing.Size(232, 141)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(72, 107)
        Me.Button20.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(88, 27)
        Me.Button20.TabIndex = 42
        Me.Button20.Text = "Mostrar"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Sanitariocontrole3TextBox
        '
        Me.Sanitariocontrole3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Sanitariocontrole3", True))
        Me.Sanitariocontrole3TextBox.Location = New System.Drawing.Point(166, 80)
        Me.Sanitariocontrole3TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Sanitariocontrole3TextBox.Name = "Sanitariocontrole3TextBox"
        Me.Sanitariocontrole3TextBox.Size = New System.Drawing.Size(42, 21)
        Me.Sanitariocontrole3TextBox.TabIndex = 41
        '
        'Sanitariocontrole2TextBox
        '
        Me.Sanitariocontrole2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Sanitariocontrole2", True))
        Me.Sanitariocontrole2TextBox.Location = New System.Drawing.Point(80, 80)
        Me.Sanitariocontrole2TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Sanitariocontrole2TextBox.Name = "Sanitariocontrole2TextBox"
        Me.Sanitariocontrole2TextBox.Size = New System.Drawing.Size(72, 21)
        Me.Sanitariocontrole2TextBox.TabIndex = 41
        '
        'Sanitariocontrole1TextBox
        '
        Me.Sanitariocontrole1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Sanitariocontrole1", True))
        Me.Sanitariocontrole1TextBox.Location = New System.Drawing.Point(27, 80)
        Me.Sanitariocontrole1TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Sanitariocontrole1TextBox.Name = "Sanitariocontrole1TextBox"
        Me.Sanitariocontrole1TextBox.Size = New System.Drawing.Size(42, 21)
        Me.Sanitariocontrole1TextBox.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(153, 83)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(69, 83)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 59)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Código de Controle:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Autenticidade de Certidão"
        '
        'SanitarioExigenciaRichTextBox
        '
        Me.SanitarioExigenciaRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "SanitarioExigencia", True))
        Me.SanitarioExigenciaRichTextBox.Location = New System.Drawing.Point(16, 33)
        Me.SanitarioExigenciaRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SanitarioExigenciaRichTextBox.Name = "SanitarioExigenciaRichTextBox"
        Me.SanitarioExigenciaRichTextBox.Size = New System.Drawing.Size(311, 101)
        Me.SanitarioExigenciaRichTextBox.TabIndex = 1
        Me.SanitarioExigenciaRichTextBox.Text = ""
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.GroupBoxDatProvSetran)
        Me.TabPage5.Controls.Add(SetranExigenciaLabel)
        Me.TabPage5.Controls.Add(Me.SetranExigenciaRichTextBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(589, 207)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Setran"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBoxDatProvSetran
        '
        Me.GroupBoxDatProvSetran.Controls.Add(Me.SetranProvisorioDATAMaskedTextBox)
        Me.GroupBoxDatProvSetran.Controls.Add(Me.ButtonAddDataSetran)
        Me.GroupBoxDatProvSetran.Controls.Add(Me.ButtonApagaDataSetran)
        Me.GroupBoxDatProvSetran.Location = New System.Drawing.Point(16, 144)
        Me.GroupBoxDatProvSetran.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvSetran.Name = "GroupBoxDatProvSetran"
        Me.GroupBoxDatProvSetran.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxDatProvSetran.Size = New System.Drawing.Size(166, 53)
        Me.GroupBoxDatProvSetran.TabIndex = 23
        Me.GroupBoxDatProvSetran.TabStop = False
        Me.GroupBoxDatProvSetran.Text = "Vencimento Provisório:"
        '
        'SetranProvisorioDATAMaskedTextBox
        '
        Me.SetranProvisorioDATAMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "SetranProvisorioDATA", True))
        Me.SetranProvisorioDATAMaskedTextBox.Location = New System.Drawing.Point(7, 22)
        Me.SetranProvisorioDATAMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SetranProvisorioDATAMaskedTextBox.Mask = "00/00/0000"
        Me.SetranProvisorioDATAMaskedTextBox.Name = "SetranProvisorioDATAMaskedTextBox"
        Me.SetranProvisorioDATAMaskedTextBox.Size = New System.Drawing.Size(76, 21)
        Me.SetranProvisorioDATAMaskedTextBox.TabIndex = 4
        Me.SetranProvisorioDATAMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ButtonAddDataSetran
        '
        Me.ButtonAddDataSetran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAddDataSetran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddDataSetran.Image = Global.PrinceSistemas.My.Resources.Resources.adicionar
        Me.ButtonAddDataSetran.Location = New System.Drawing.Point(91, 18)
        Me.ButtonAddDataSetran.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAddDataSetran.Name = "ButtonAddDataSetran"
        Me.ButtonAddDataSetran.Size = New System.Drawing.Size(29, 27)
        Me.ButtonAddDataSetran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonAddDataSetran.TabIndex = 18
        Me.ButtonAddDataSetran.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonAddDataSetran, "Adicionar / Alterar")
        '
        'ButtonApagaDataSetran
        '
        Me.ButtonApagaDataSetran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonApagaDataSetran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonApagaDataSetran.Image = Global.PrinceSistemas.My.Resources.Resources.lixeira
        Me.ButtonApagaDataSetran.Location = New System.Drawing.Point(121, 18)
        Me.ButtonApagaDataSetran.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonApagaDataSetran.Name = "ButtonApagaDataSetran"
        Me.ButtonApagaDataSetran.Size = New System.Drawing.Size(33, 27)
        Me.ButtonApagaDataSetran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonApagaDataSetran.TabIndex = 16
        Me.ButtonApagaDataSetran.TabStop = False
        Me.ToolTipMostraDescricao.SetToolTip(Me.ButtonApagaDataSetran, "Excluir e Limpar")
        '
        'SetranExigenciaRichTextBox
        '
        Me.SetranExigenciaRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "SetranExigencia", True))
        Me.SetranExigenciaRichTextBox.Location = New System.Drawing.Point(16, 33)
        Me.SetranExigenciaRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SetranExigenciaRichTextBox.Name = "SetranExigenciaRichTextBox"
        Me.SetranExigenciaRichTextBox.Size = New System.Drawing.Size(311, 101)
        Me.SetranExigenciaRichTextBox.TabIndex = 1
        Me.SetranExigenciaRichTextBox.Text = ""
        '
        'NlaudoTextBox
        '
        Me.NlaudoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Nlaudo", True))
        Me.NlaudoTextBox.Location = New System.Drawing.Point(120, 25)
        Me.NlaudoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NlaudoTextBox.Name = "NlaudoTextBox"
        Me.NlaudoTextBox.Size = New System.Drawing.Size(117, 21)
        Me.NlaudoTextBox.TabIndex = 36
        '
        'ModeloSistemaComboBox
        '
        Me.ModeloSistemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ModeloSistema", True))
        Me.ModeloSistemaComboBox.FormattingEnabled = True
        Me.ModeloSistemaComboBox.Location = New System.Drawing.Point(121, 83)
        Me.ModeloSistemaComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ModeloSistemaComboBox.Name = "ModeloSistemaComboBox"
        Me.ModeloSistemaComboBox.Size = New System.Drawing.Size(207, 23)
        Me.ModeloSistemaComboBox.TabIndex = 39
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonConsultar.BackgroundImage = CType(resources.GetObject("ButtonConsultar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConsultar.Location = New System.Drawing.Point(246, 22)
        Me.ButtonConsultar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(83, 28)
        Me.ButtonConsultar.TabIndex = 40
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = False
        '
        'ComboBoxBuscaAlvara
        '
        Me.ComboBoxBuscaAlvara.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBuscaAlvara.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBuscaAlvara.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxBuscaAlvara.DataSource = Me.LaudosBindingSource
        Me.ComboBoxBuscaAlvara.DisplayMember = "RazaoSocial"
        Me.ComboBoxBuscaAlvara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxBuscaAlvara.FormattingEnabled = True
        Me.ComboBoxBuscaAlvara.Location = New System.Drawing.Point(285, 1)
        Me.ComboBoxBuscaAlvara.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBoxBuscaAlvara.Name = "ComboBoxBuscaAlvara"
        Me.ComboBoxBuscaAlvara.Size = New System.Drawing.Size(285, 23)
        Me.ComboBoxBuscaAlvara.TabIndex = 42
        Me.ComboBoxBuscaAlvara.ValueMember = "RazaoSocial"
        '
        'BtnCalendarioWindows
        '
        Me.BtnCalendarioWindows.BackgroundImage = CType(resources.GetObject("BtnCalendarioWindows.BackgroundImage"), System.Drawing.Image)
        Me.BtnCalendarioWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCalendarioWindows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalendarioWindows.Location = New System.Drawing.Point(9, 147)
        Me.BtnCalendarioWindows.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCalendarioWindows.Name = "BtnCalendarioWindows"
        Me.BtnCalendarioWindows.Size = New System.Drawing.Size(156, 25)
        Me.BtnCalendarioWindows.TabIndex = 43
        Me.BtnCalendarioWindows.Text = "Calendário do Windows"
        Me.BtnCalendarioWindows.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Location = New System.Drawing.Point(7, 192)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(80, 27)
        Me.Button19.TabIndex = 49
        Me.Button19.Text = "Fechar"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Location = New System.Drawing.Point(7, 52)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(80, 27)
        Me.BtnSalvar.TabIndex = 48
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.FundoBtnFechar
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button17.Location = New System.Drawing.Point(7, 159)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(80, 27)
        Me.Button17.TabIndex = 47
        Me.Button17.Text = "Excluir"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.BackgroundImage = CType(resources.GetObject("BtnNovo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.ForeColor = System.Drawing.Color.Green
        Me.BtnNovo.Location = New System.Drawing.Point(7, 19)
        Me.BtnNovo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(80, 25)
        Me.BtnNovo.TabIndex = 46
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LabelSetranDataProvisorio)
        Me.GroupBox3.Controls.Add(Me.LabelSanitarioDataProvisorio)
        Me.GroupBox3.Controls.Add(Me.BtnCalendarioWindows)
        Me.GroupBox3.Controls.Add(Me.LabelViabilidadeDataProvisorio)
        Me.GroupBox3.Controls.Add(Me.LabelAmbientalDataProvisorio)
        Me.GroupBox3.Controls.Add(Me.LabelBombeiroDataProvisorio)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(699, 12)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(195, 192)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vencimento Alvará Provisório "
        '
        'LabelSetranDataProvisorio
        '
        Me.LabelSetranDataProvisorio.AutoSize = True
        Me.LabelSetranDataProvisorio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "SetranProvisorioDATA", True))
        Me.LabelSetranDataProvisorio.Location = New System.Drawing.Point(80, 125)
        Me.LabelSetranDataProvisorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSetranDataProvisorio.Name = "LabelSetranDataProvisorio"
        Me.LabelSetranDataProvisorio.Size = New System.Drawing.Size(62, 15)
        Me.LabelSetranDataProvisorio.TabIndex = 85
        Me.LabelSetranDataProvisorio.Text = "Sem Data"
        '
        'LabelSanitarioDataProvisorio
        '
        Me.LabelSanitarioDataProvisorio.AutoSize = True
        Me.LabelSanitarioDataProvisorio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "SanitarioProvisorioDATA", True))
        Me.LabelSanitarioDataProvisorio.Location = New System.Drawing.Point(80, 102)
        Me.LabelSanitarioDataProvisorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSanitarioDataProvisorio.Name = "LabelSanitarioDataProvisorio"
        Me.LabelSanitarioDataProvisorio.Size = New System.Drawing.Size(62, 15)
        Me.LabelSanitarioDataProvisorio.TabIndex = 84
        Me.LabelSanitarioDataProvisorio.Text = "Sem Data"
        '
        'LabelViabilidadeDataProvisorio
        '
        Me.LabelViabilidadeDataProvisorio.AutoSize = True
        Me.LabelViabilidadeDataProvisorio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ViabilidadeProvisorioDATA", True))
        Me.LabelViabilidadeDataProvisorio.Location = New System.Drawing.Point(80, 77)
        Me.LabelViabilidadeDataProvisorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelViabilidadeDataProvisorio.Name = "LabelViabilidadeDataProvisorio"
        Me.LabelViabilidadeDataProvisorio.Size = New System.Drawing.Size(62, 15)
        Me.LabelViabilidadeDataProvisorio.TabIndex = 83
        Me.LabelViabilidadeDataProvisorio.Text = "Sem Data"
        '
        'LabelAmbientalDataProvisorio
        '
        Me.LabelAmbientalDataProvisorio.AutoSize = True
        Me.LabelAmbientalDataProvisorio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "AmbientalProvisorioDATA", True))
        Me.LabelAmbientalDataProvisorio.Location = New System.Drawing.Point(80, 51)
        Me.LabelAmbientalDataProvisorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAmbientalDataProvisorio.Name = "LabelAmbientalDataProvisorio"
        Me.LabelAmbientalDataProvisorio.Size = New System.Drawing.Size(62, 15)
        Me.LabelAmbientalDataProvisorio.TabIndex = 82
        Me.LabelAmbientalDataProvisorio.Text = "Sem Data"
        '
        'LabelBombeiroDataProvisorio
        '
        Me.LabelBombeiroDataProvisorio.AutoSize = True
        Me.LabelBombeiroDataProvisorio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "BombeiroProvisorioDATA", True))
        Me.LabelBombeiroDataProvisorio.Location = New System.Drawing.Point(80, 29)
        Me.LabelBombeiroDataProvisorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBombeiroDataProvisorio.Name = "LabelBombeiroDataProvisorio"
        Me.LabelBombeiroDataProvisorio.Size = New System.Drawing.Size(62, 15)
        Me.LabelBombeiroDataProvisorio.TabIndex = 81
        Me.LabelBombeiroDataProvisorio.Text = "Sem Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 125)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Setran:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 102)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Sanitário:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Viabilidade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Ambiental:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Bombeiro:"
        '
        'CADSituacaoAlvaraBindingSource
        '
        Me.CADSituacaoAlvaraBindingSource.DataMember = "CADSituacaoAlvara"
        Me.CADSituacaoAlvaraBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(NlaudoSecundarioLabel)
        Me.GroupBox4.Controls.Add(Me.BtnVerObsGeral)
        Me.GroupBox4.Controls.Add(Me.NlaudoSecundarioTextBox)
        Me.GroupBox4.Controls.Add(Me.ObservacaoRichTextBox)
        Me.GroupBox4.Controls.Add(Me.BtnAnotacoes)
        Me.GroupBox4.Controls.Add(Me.NlaudoLabel)
        Me.GroupBox4.Controls.Add(Me.BtnBombVer)
        Me.GroupBox4.Controls.Add(BombeiroSituacaoLabel)
        Me.GroupBox4.Controls.Add(Me.BombeiroSituacaoComboBox)
        Me.GroupBox4.Controls.Add(Me.TabAlvara)
        Me.GroupBox4.Controls.Add(ObservacaoLabel)
        Me.GroupBox4.Controls.Add(Me.ButtonConsultar)
        Me.GroupBox4.Controls.Add(Me.ButtonSolicitar)
        Me.GroupBox4.Controls.Add(ModeloSistemaLabel)
        Me.GroupBox4.Controls.Add(Me.NlaudoTextBox)
        Me.GroupBox4.Controls.Add(Me.ModeloSistemaComboBox)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(4, 248)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(902, 501)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CENTRAL DE LAUDOS E ALVARÁS"
        '
        'BtnVerObsGeral
        '
        Me.BtnVerObsGeral.BackgroundImage = CType(resources.GetObject("BtnVerObsGeral.BackgroundImage"), System.Drawing.Image)
        Me.BtnVerObsGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVerObsGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerObsGeral.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnVerObsGeral.Location = New System.Drawing.Point(442, 121)
        Me.BtnVerObsGeral.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnVerObsGeral.Name = "BtnVerObsGeral"
        Me.BtnVerObsGeral.Size = New System.Drawing.Size(93, 27)
        Me.BtnVerObsGeral.TabIndex = 81
        Me.BtnVerObsGeral.Text = "Ver Completo"
        Me.BtnVerObsGeral.UseVisualStyleBackColor = True
        '
        'NlaudoSecundarioTextBox
        '
        Me.NlaudoSecundarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "NlaudoSecundario", True))
        Me.NlaudoSecundarioTextBox.Location = New System.Drawing.Point(120, 53)
        Me.NlaudoSecundarioTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NlaudoSecundarioTextBox.Name = "NlaudoSecundarioTextBox"
        Me.NlaudoSecundarioTextBox.Size = New System.Drawing.Size(117, 21)
        Me.NlaudoSecundarioTextBox.TabIndex = 58
        '
        'ObservacaoRichTextBox
        '
        Me.ObservacaoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Observacao", True))
        Me.ObservacaoRichTextBox.Location = New System.Drawing.Point(442, 29)
        Me.ObservacaoRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ObservacaoRichTextBox.Name = "ObservacaoRichTextBox"
        Me.ObservacaoRichTextBox.Size = New System.Drawing.Size(462, 89)
        Me.ObservacaoRichTextBox.TabIndex = 80
        Me.ObservacaoRichTextBox.Text = ""
        '
        'BtnAnotacoes
        '
        Me.BtnAnotacoes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnAnotacoes.BackgroundImage = CType(resources.GetObject("BtnAnotacoes.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnotacoes.Location = New System.Drawing.Point(336, 22)
        Me.BtnAnotacoes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAnotacoes.Name = "BtnAnotacoes"
        Me.BtnAnotacoes.Size = New System.Drawing.Size(47, 28)
        Me.BtnAnotacoes.TabIndex = 79
        Me.BtnAnotacoes.Text = "Ver"
        Me.BtnAnotacoes.UseVisualStyleBackColor = False
        '
        'NlaudoLabel
        '
        Me.NlaudoLabel.AutoSize = True
        Me.NlaudoLabel.Location = New System.Drawing.Point(35, 29)
        Me.NlaudoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NlaudoLabel.Name = "NlaudoLabel"
        Me.NlaudoLabel.Size = New System.Drawing.Size(78, 15)
        Me.NlaudoLabel.TabIndex = 78
        Me.NlaudoLabel.Text = "Nº do Laudo:"
        '
        'BtnBombVer
        '
        Me.BtnBombVer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnBombVer.BackgroundImage = CType(resources.GetObject("BtnBombVer.BackgroundImage"), System.Drawing.Image)
        Me.BtnBombVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBombVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBombVer.Location = New System.Drawing.Point(335, 114)
        Me.BtnBombVer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBombVer.Name = "BtnBombVer"
        Me.BtnBombVer.Size = New System.Drawing.Size(48, 24)
        Me.BtnBombVer.TabIndex = 77
        Me.BtnBombVer.Text = "Ver"
        Me.BtnBombVer.UseVisualStyleBackColor = False
        '
        'BombeiroSituacaoComboBox
        '
        Me.BombeiroSituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "BombeiroSituacao", True))
        Me.BombeiroSituacaoComboBox.FormattingEnabled = True
        Me.BombeiroSituacaoComboBox.Location = New System.Drawing.Point(120, 114)
        Me.BombeiroSituacaoComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BombeiroSituacaoComboBox.Name = "BombeiroSituacaoComboBox"
        Me.BombeiroSituacaoComboBox.Size = New System.Drawing.Size(204, 23)
        Me.BombeiroSituacaoComboBox.TabIndex = 76
        '
        'TabAlvara
        '
        Me.TabAlvara.Controls.Add(Me.TabPage12)
        Me.TabAlvara.Controls.Add(Me.TabPage13)
        Me.TabAlvara.Controls.Add(Me.TabPage14)
        Me.TabAlvara.Controls.Add(Me.TabPage15)
        Me.TabAlvara.Controls.Add(Me.TabPage16)
        Me.TabAlvara.Location = New System.Drawing.Point(0, 144)
        Me.TabAlvara.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabAlvara.Multiline = True
        Me.TabAlvara.Name = "TabAlvara"
        Me.TabAlvara.SelectedIndex = 0
        Me.TabAlvara.Size = New System.Drawing.Size(913, 337)
        Me.TabAlvara.TabIndex = 75
        '
        'TabPage12
        '
        Me.TabPage12.AutoScroll = True
        Me.TabPage12.Controls.Add(Me.BtnAtualizarDados)
        Me.TabPage12.Controls.Add(Me.TabControl2)
        Me.TabPage12.Location = New System.Drawing.Point(4, 24)
        Me.TabPage12.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage12.Size = New System.Drawing.Size(905, 309)
        Me.TabPage12.TabIndex = 0
        Me.TabPage12.Text = "Dados Cadastrais"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'BtnAtualizarDados
        '
        Me.BtnAtualizarDados.BackgroundImage = CType(resources.GetObject("BtnAtualizarDados.BackgroundImage"), System.Drawing.Image)
        Me.BtnAtualizarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAtualizarDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtualizarDados.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnAtualizarDados.Location = New System.Drawing.Point(719, 24)
        Me.BtnAtualizarDados.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAtualizarDados.Name = "BtnAtualizarDados"
        Me.BtnAtualizarDados.Size = New System.Drawing.Size(141, 54)
        Me.BtnAtualizarDados.TabIndex = 57
        Me.BtnAtualizarDados.Text = "Atualizar Dados Cadastrais"
        Me.BtnAtualizarDados.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Controls.Add(Me.TabPage11)
        Me.TabControl2.Location = New System.Drawing.Point(35, 17)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(650, 269)
        Me.TabControl2.TabIndex = 32
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(NaturezaDoPedidoOBSLabel)
        Me.TabPage6.Controls.Add(Me.NaturezaDoPedidoOBSRichTextBox)
        Me.TabPage6.Location = New System.Drawing.Point(4, 27)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(642, 238)
        Me.TabPage6.TabIndex = 4
        Me.TabPage6.Text = "Observação"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'NaturezaDoPedidoOBSRichTextBox
        '
        Me.NaturezaDoPedidoOBSRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "NaturezaDoPedidoOBS", True))
        Me.NaturezaDoPedidoOBSRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NaturezaDoPedidoOBSRichTextBox.Location = New System.Drawing.Point(20, 40)
        Me.NaturezaDoPedidoOBSRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NaturezaDoPedidoOBSRichTextBox.Name = "NaturezaDoPedidoOBSRichTextBox"
        Me.NaturezaDoPedidoOBSRichTextBox.Size = New System.Drawing.Size(599, 148)
        Me.NaturezaDoPedidoOBSRichTextBox.TabIndex = 30
        Me.NaturezaDoPedidoOBSRichTextBox.Text = ""
        '
        'TabPage7
        '
        Me.TabPage7.AutoScroll = True
        Me.TabPage7.Controls.Add(Me.BtnCopiaCEP)
        Me.TabPage7.Controls.Add(Me.BtnMapa)
        Me.TabPage7.Controls.Add(Me.EndCidadeTextBox)
        Me.TabPage7.Controls.Add(Me.PontoRefTextBox)
        Me.TabPage7.Controls.Add(Me.EndBairroTextBox)
        Me.TabPage7.Controls.Add(Me.EndCompTextBox)
        Me.TabPage7.Controls.Add(Me.EnderecoTextBox)
        Me.TabPage7.Controls.Add(PontoRefLabel)
        Me.TabPage7.Controls.Add(Me.Button21)
        Me.TabPage7.Controls.Add(Me.Area2TextBox)
        Me.TabPage7.Controls.Add(Me.AreaTextBox)
        Me.TabPage7.Controls.Add(Me.CadImobTextBox)
        Me.TabPage7.Controls.Add(Me.EndDataTextBox)
        Me.TabPage7.Controls.Add(Me.EndQuadraTextBox)
        Me.TabPage7.Controls.Add(Me.EndZonaTextBox)
        Me.TabPage7.Controls.Add(Me.EndNumTextBox)
        Me.TabPage7.Controls.Add(Me.EndEstadoTextBox)
        Me.TabPage7.Controls.Add(Area2Label)
        Me.TabPage7.Controls.Add(AreaLabel)
        Me.TabPage7.Controls.Add(CadImobLabel)
        Me.TabPage7.Controls.Add(EndDataLabel)
        Me.TabPage7.Controls.Add(EndQuadraLabel)
        Me.TabPage7.Controls.Add(EndZonaLabel)
        Me.TabPage7.Controls.Add(EndCEPLabel)
        Me.TabPage7.Controls.Add(EnderecoLabel)
        Me.TabPage7.Controls.Add(EndNumLabel)
        Me.TabPage7.Controls.Add(EndCompLabel)
        Me.TabPage7.Controls.Add(EndBairroLabel)
        Me.TabPage7.Controls.Add(Me.EndCEPMaskedTextBox)
        Me.TabPage7.Controls.Add(Me.Button22)
        Me.TabPage7.Controls.Add(EndEstadoLabel)
        Me.TabPage7.Controls.Add(EndCidadeLabel)
        Me.TabPage7.Location = New System.Drawing.Point(4, 27)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage7.Size = New System.Drawing.Size(642, 238)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Endereço"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'BtnCopiaCEP
        '
        Me.BtnCopiaCEP.BackColor = System.Drawing.Color.Azure
        Me.BtnCopiaCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiaCEP.Location = New System.Drawing.Point(266, 23)
        Me.BtnCopiaCEP.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCopiaCEP.Name = "BtnCopiaCEP"
        Me.BtnCopiaCEP.Size = New System.Drawing.Size(85, 25)
        Me.BtnCopiaCEP.TabIndex = 74
        Me.BtnCopiaCEP.Text = "Copiar CEP"
        Me.BtnCopiaCEP.UseVisualStyleBackColor = False
        '
        'BtnMapa
        '
        Me.BtnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMapa.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnMapa.Location = New System.Drawing.Point(554, 20)
        Me.BtnMapa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnMapa.Name = "BtnMapa"
        Me.BtnMapa.Size = New System.Drawing.Size(61, 29)
        Me.BtnMapa.TabIndex = 73
        Me.BtnMapa.Text = "Mapa"
        Me.BtnMapa.UseVisualStyleBackColor = True
        '
        'EndCidadeTextBox
        '
        Me.EndCidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndCidade", True))
        Me.EndCidadeTextBox.Location = New System.Drawing.Point(97, 173)
        Me.EndCidadeTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndCidadeTextBox.Name = "EndCidadeTextBox"
        Me.EndCidadeTextBox.Size = New System.Drawing.Size(136, 21)
        Me.EndCidadeTextBox.TabIndex = 57
        '
        'PontoRefTextBox
        '
        Me.PontoRefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "PontoRef", True))
        Me.PontoRefTextBox.Location = New System.Drawing.Point(407, 143)
        Me.PontoRefTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PontoRefTextBox.Name = "PontoRefTextBox"
        Me.PontoRefTextBox.Size = New System.Drawing.Size(207, 21)
        Me.PontoRefTextBox.TabIndex = 56
        '
        'EndBairroTextBox
        '
        Me.EndBairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndBairro", True))
        Me.EndBairroTextBox.Location = New System.Drawing.Point(97, 143)
        Me.EndBairroTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndBairroTextBox.Name = "EndBairroTextBox"
        Me.EndBairroTextBox.Size = New System.Drawing.Size(170, 21)
        Me.EndBairroTextBox.TabIndex = 55
        '
        'EndCompTextBox
        '
        Me.EndCompTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndComp", True))
        Me.EndCompTextBox.Location = New System.Drawing.Point(273, 83)
        Me.EndCompTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndCompTextBox.Name = "EndCompTextBox"
        Me.EndCompTextBox.Size = New System.Drawing.Size(341, 21)
        Me.EndCompTextBox.TabIndex = 54
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(97, 53)
        Me.EnderecoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(517, 21)
        Me.EnderecoTextBox.TabIndex = 53
        '
        'Button21
        '
        Me.Button21.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button21.Location = New System.Drawing.Point(552, 113)
        Me.Button21.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(63, 22)
        Me.Button21.TabIndex = 51
        Me.Button21.Text = "Buscar"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Area2TextBox
        '
        Me.Area2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "area2", True))
        Me.Area2TextBox.Location = New System.Drawing.Point(447, 208)
        Me.Area2TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Area2TextBox.Name = "Area2TextBox"
        Me.Area2TextBox.Size = New System.Drawing.Size(94, 21)
        Me.Area2TextBox.TabIndex = 42
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(145, 208)
        Me.AreaTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(94, 21)
        Me.AreaTextBox.TabIndex = 41
        '
        'CadImobTextBox
        '
        Me.CadImobTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CadImob", True))
        Me.CadImobTextBox.Location = New System.Drawing.Point(441, 113)
        Me.CadImobTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CadImobTextBox.Name = "CadImobTextBox"
        Me.CadImobTextBox.Size = New System.Drawing.Size(103, 21)
        Me.CadImobTextBox.TabIndex = 40
        '
        'EndDataTextBox
        '
        Me.EndDataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndData", True))
        Me.EndDataTextBox.Location = New System.Drawing.Point(273, 113)
        Me.EndDataTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndDataTextBox.Name = "EndDataTextBox"
        Me.EndDataTextBox.Size = New System.Drawing.Size(40, 21)
        Me.EndDataTextBox.TabIndex = 29
        '
        'EndQuadraTextBox
        '
        Me.EndQuadraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndQuadra", True))
        Me.EndQuadraTextBox.Location = New System.Drawing.Point(192, 113)
        Me.EndQuadraTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndQuadraTextBox.Name = "EndQuadraTextBox"
        Me.EndQuadraTextBox.Size = New System.Drawing.Size(40, 21)
        Me.EndQuadraTextBox.TabIndex = 28
        '
        'EndZonaTextBox
        '
        Me.EndZonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndZona", True))
        Me.EndZonaTextBox.Location = New System.Drawing.Point(97, 113)
        Me.EndZonaTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndZonaTextBox.Name = "EndZonaTextBox"
        Me.EndZonaTextBox.Size = New System.Drawing.Size(40, 21)
        Me.EndZonaTextBox.TabIndex = 27
        '
        'EndNumTextBox
        '
        Me.EndNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndNum", True))
        Me.EndNumTextBox.Location = New System.Drawing.Point(97, 83)
        Me.EndNumTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndNumTextBox.Name = "EndNumTextBox"
        Me.EndNumTextBox.Size = New System.Drawing.Size(74, 21)
        Me.EndNumTextBox.TabIndex = 8
        '
        'EndEstadoTextBox
        '
        Me.EndEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndEstado", True))
        Me.EndEstadoTextBox.Location = New System.Drawing.Point(298, 173)
        Me.EndEstadoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndEstadoTextBox.Name = "EndEstadoTextBox"
        Me.EndEstadoTextBox.Size = New System.Drawing.Size(44, 21)
        Me.EndEstadoTextBox.TabIndex = 19
        '
        'EndCEPMaskedTextBox
        '
        Me.EndCEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndCEP", True))
        Me.EndCEPMaskedTextBox.Location = New System.Drawing.Point(97, 23)
        Me.EndCEPMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndCEPMaskedTextBox.Mask = "00000-000"
        Me.EndCEPMaskedTextBox.Name = "EndCEPMaskedTextBox"
        Me.EndCEPMaskedTextBox.Size = New System.Drawing.Size(74, 21)
        Me.EndCEPMaskedTextBox.TabIndex = 14
        '
        'Button22
        '
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button22.Location = New System.Drawing.Point(176, 22)
        Me.Button22.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(83, 27)
        Me.Button22.TabIndex = 17
        Me.Button22.Text = "Preencher"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.ResptecnicoTextBox)
        Me.TabPage8.Controls.Add(Me.ResptecnicoNumeroTextBox)
        Me.TabPage8.Controls.Add(ResptecnicoLabel)
        Me.TabPage8.Controls.Add(ResptecnicoNumeroLabel)
        Me.TabPage8.Location = New System.Drawing.Point(4, 27)
        Me.TabPage8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage8.Size = New System.Drawing.Size(642, 238)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "Técnico"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'ResptecnicoTextBox
        '
        Me.ResptecnicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Resptecnico", True))
        Me.ResptecnicoTextBox.Location = New System.Drawing.Point(118, 25)
        Me.ResptecnicoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ResptecnicoTextBox.Name = "ResptecnicoTextBox"
        Me.ResptecnicoTextBox.Size = New System.Drawing.Size(489, 21)
        Me.ResptecnicoTextBox.TabIndex = 21
        '
        'ResptecnicoNumeroTextBox
        '
        Me.ResptecnicoNumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ResptecnicoNumero", True))
        Me.ResptecnicoNumeroTextBox.Location = New System.Drawing.Point(118, 55)
        Me.ResptecnicoNumeroTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ResptecnicoNumeroTextBox.Name = "ResptecnicoNumeroTextBox"
        Me.ResptecnicoNumeroTextBox.Size = New System.Drawing.Size(116, 21)
        Me.ResptecnicoNumeroTextBox.TabIndex = 23
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.BtnGrauDeRisco)
        Me.TabPage10.Controls.Add(RamodeatividadeLabel)
        Me.TabPage10.Controls.Add(Me.RamodeatividadeRichTextBox)
        Me.TabPage10.Controls.Add(Me.CNAERichTextBox)
        Me.TabPage10.Controls.Add(CNAELabel)
        Me.TabPage10.Location = New System.Drawing.Point(4, 27)
        Me.TabPage10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage10.Size = New System.Drawing.Size(642, 238)
        Me.TabPage10.TabIndex = 3
        Me.TabPage10.Text = "Ramo de Atividade"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'BtnGrauDeRisco
        '
        Me.BtnGrauDeRisco.BackgroundImage = CType(resources.GetObject("BtnGrauDeRisco.BackgroundImage"), System.Drawing.Image)
        Me.BtnGrauDeRisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGrauDeRisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrauDeRisco.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnGrauDeRisco.Location = New System.Drawing.Point(523, 37)
        Me.BtnGrauDeRisco.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGrauDeRisco.Name = "BtnGrauDeRisco"
        Me.BtnGrauDeRisco.Size = New System.Drawing.Size(108, 27)
        Me.BtnGrauDeRisco.TabIndex = 81
        Me.BtnGrauDeRisco.Text = "Grau de Risco"
        Me.BtnGrauDeRisco.UseVisualStyleBackColor = True
        '
        'RamodeatividadeRichTextBox
        '
        Me.RamodeatividadeRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Ramodeatividade", True))
        Me.RamodeatividadeRichTextBox.Location = New System.Drawing.Point(134, 37)
        Me.RamodeatividadeRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RamodeatividadeRichTextBox.Name = "RamodeatividadeRichTextBox"
        Me.RamodeatividadeRichTextBox.Size = New System.Drawing.Size(381, 186)
        Me.RamodeatividadeRichTextBox.TabIndex = 25
        Me.RamodeatividadeRichTextBox.Text = ""
        '
        'CNAERichTextBox
        '
        Me.CNAERichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CNAE", True))
        Me.CNAERichTextBox.Location = New System.Drawing.Point(18, 37)
        Me.CNAERichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CNAERichTextBox.Name = "CNAERichTextBox"
        Me.CNAERichTextBox.Size = New System.Drawing.Size(109, 186)
        Me.CNAERichTextBox.TabIndex = 24
        Me.CNAERichTextBox.Text = ""
        '
        'TabPage9
        '
        Me.TabPage9.AutoScroll = True
        Me.TabPage9.Controls.Add(Me.BtnImportaSocio)
        Me.TabPage9.Controls.Add(Me.GroupBox8)
        Me.TabPage9.Location = New System.Drawing.Point(4, 27)
        Me.TabPage9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage9.Size = New System.Drawing.Size(642, 238)
        Me.TabPage9.TabIndex = 2
        Me.TabPage9.Text = "Requerente"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'BtnImportaSocio
        '
        Me.BtnImportaSocio.BackgroundImage = CType(resources.GetObject("BtnImportaSocio.BackgroundImage"), System.Drawing.Image)
        Me.BtnImportaSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImportaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportaSocio.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnImportaSocio.Location = New System.Drawing.Point(551, 29)
        Me.BtnImportaSocio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnImportaSocio.Name = "BtnImportaSocio"
        Me.BtnImportaSocio.Size = New System.Drawing.Size(80, 51)
        Me.BtnImportaSocio.TabIndex = 82
        Me.BtnImportaSocio.Text = "Importar Sócio"
        Me.BtnImportaSocio.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(EstadoOrgaoRGRequerenteLabel)
        Me.GroupBox8.Controls.Add(Me.Button23)
        Me.GroupBox8.Controls.Add(Me.EstadoOrgaoRGRequerenteTextBox)
        Me.GroupBox8.Controls.Add(CNPJRequerenteLabel)
        Me.GroupBox8.Controls.Add(OrgaoRGRequerenteLabel)
        Me.GroupBox8.Controls.Add(Me.CNPJRequerenteMaskedTextBox)
        Me.GroupBox8.Controls.Add(Me.OrgaoRGRequerenteTextBox)
        Me.GroupBox8.Controls.Add(RGRequerenteLabel)
        Me.GroupBox8.Controls.Add(Me.RGRequerenteTextBox)
        Me.GroupBox8.Controls.Add(CPFRequerenteLabel)
        Me.GroupBox8.Controls.Add(Me.CPFRequerenteMaskedTextBox)
        Me.GroupBox8.Controls.Add(EmailRequerenteLabel)
        Me.GroupBox8.Controls.Add(Me.EmailRequerenteTextBox)
        Me.GroupBox8.Controls.Add(FoneRequerenteLabel)
        Me.GroupBox8.Controls.Add(Me.FoneRequerenteTextBox)
        Me.GroupBox8.Controls.Add(EndRequerenteLabel)
        Me.GroupBox8.Controls.Add(Me.EndRequerenteTextBox)
        Me.GroupBox8.Controls.Add(RequerenteLabel)
        Me.GroupBox8.Controls.Add(Me.RequerenteTextBox)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox8.Size = New System.Drawing.Size(536, 225)
        Me.GroupBox8.TabIndex = 32
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Requerente do Laudo"
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button23.Location = New System.Drawing.Point(76, 95)
        Me.Button23.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(169, 27)
        Me.Button23.TabIndex = 46
        Me.Button23.Text = "Preenchimento Automático"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'EstadoOrgaoRGRequerenteTextBox
        '
        Me.EstadoOrgaoRGRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EstadoOrgaoRGRequerente", True))
        Me.EstadoOrgaoRGRequerenteTextBox.Location = New System.Drawing.Point(478, 54)
        Me.EstadoOrgaoRGRequerenteTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EstadoOrgaoRGRequerenteTextBox.Name = "EstadoOrgaoRGRequerenteTextBox"
        Me.EstadoOrgaoRGRequerenteTextBox.Size = New System.Drawing.Size(48, 21)
        Me.EstadoOrgaoRGRequerenteTextBox.TabIndex = 59
        '
        'CNPJRequerenteMaskedTextBox
        '
        Me.CNPJRequerenteMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CNPJRequerente", True))
        Me.CNPJRequerenteMaskedTextBox.Location = New System.Drawing.Point(76, 128)
        Me.CNPJRequerenteMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CNPJRequerenteMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJRequerenteMaskedTextBox.Name = "CNPJRequerenteMaskedTextBox"
        Me.CNPJRequerenteMaskedTextBox.Size = New System.Drawing.Size(124, 21)
        Me.CNPJRequerenteMaskedTextBox.TabIndex = 34
        '
        'OrgaoRGRequerenteTextBox
        '
        Me.OrgaoRGRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "OrgaoRGRequerente", True))
        Me.OrgaoRGRequerenteTextBox.Location = New System.Drawing.Point(362, 54)
        Me.OrgaoRGRequerenteTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OrgaoRGRequerenteTextBox.Name = "OrgaoRGRequerenteTextBox"
        Me.OrgaoRGRequerenteTextBox.Size = New System.Drawing.Size(65, 21)
        Me.OrgaoRGRequerenteTextBox.TabIndex = 58
        '
        'RGRequerenteTextBox
        '
        Me.RGRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "RGRequerente", True))
        Me.RGRequerenteTextBox.Location = New System.Drawing.Point(210, 54)
        Me.RGRequerenteTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RGRequerenteTextBox.Name = "RGRequerenteTextBox"
        Me.RGRequerenteTextBox.Size = New System.Drawing.Size(102, 21)
        Me.RGRequerenteTextBox.TabIndex = 33
        '
        'CPFRequerenteMaskedTextBox
        '
        Me.CPFRequerenteMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CPFRequerente", True))
        Me.CPFRequerenteMaskedTextBox.Location = New System.Drawing.Point(76, 54)
        Me.CPFRequerenteMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CPFRequerenteMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFRequerenteMaskedTextBox.Name = "CPFRequerenteMaskedTextBox"
        Me.CPFRequerenteMaskedTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CPFRequerenteMaskedTextBox.TabIndex = 32
        '
        'EmailRequerenteTextBox
        '
        Me.EmailRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EmailRequerente", True))
        Me.EmailRequerenteTextBox.Location = New System.Drawing.Point(246, 188)
        Me.EmailRequerenteTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailRequerenteTextBox.MaxLength = 1000
        Me.EmailRequerenteTextBox.Name = "EmailRequerenteTextBox"
        Me.EmailRequerenteTextBox.Size = New System.Drawing.Size(280, 21)
        Me.EmailRequerenteTextBox.TabIndex = 29
        '
        'FoneRequerenteTextBox
        '
        Me.FoneRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "FoneRequerente", True))
        Me.FoneRequerenteTextBox.Location = New System.Drawing.Point(76, 188)
        Me.FoneRequerenteTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FoneRequerenteTextBox.Name = "FoneRequerenteTextBox"
        Me.FoneRequerenteTextBox.Size = New System.Drawing.Size(116, 21)
        Me.FoneRequerenteTextBox.TabIndex = 28
        '
        'EndRequerenteTextBox
        '
        Me.EndRequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndRequerente", True))
        Me.EndRequerenteTextBox.Location = New System.Drawing.Point(76, 158)
        Me.EndRequerenteTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EndRequerenteTextBox.MaxLength = 1000
        Me.EndRequerenteTextBox.Name = "EndRequerenteTextBox"
        Me.EndRequerenteTextBox.Size = New System.Drawing.Size(451, 21)
        Me.EndRequerenteTextBox.TabIndex = 27
        '
        'RequerenteTextBox
        '
        Me.RequerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Requerente", True))
        Me.RequerenteTextBox.Location = New System.Drawing.Point(76, 24)
        Me.RequerenteTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RequerenteTextBox.Name = "RequerenteTextBox"
        Me.RequerenteTextBox.Size = New System.Drawing.Size(451, 21)
        Me.RequerenteTextBox.TabIndex = 25
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.Button25)
        Me.TabPage11.Controls.Add(Me.NaturezaDoPedidoRichTextBox)
        Me.TabPage11.Controls.Add(NaturezaDoPedidoLabel)
        Me.TabPage11.Controls.Add(Me.NaturezaListBox)
        Me.TabPage11.Location = New System.Drawing.Point(4, 27)
        Me.TabPage11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(642, 238)
        Me.TabPage11.TabIndex = 5
        Me.TabPage11.Text = "Natureza do Pedido"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Location = New System.Drawing.Point(310, 104)
        Me.Button25.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(35, 37)
        Me.Button25.TabIndex = 39
        Me.Button25.Text = "<<"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'NaturezaDoPedidoRichTextBox
        '
        Me.NaturezaDoPedidoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "NaturezaDoPedido", True))
        Me.NaturezaDoPedidoRichTextBox.Location = New System.Drawing.Point(15, 38)
        Me.NaturezaDoPedidoRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NaturezaDoPedidoRichTextBox.Name = "NaturezaDoPedidoRichTextBox"
        Me.NaturezaDoPedidoRichTextBox.Size = New System.Drawing.Size(290, 184)
        Me.NaturezaDoPedidoRichTextBox.TabIndex = 37
        Me.NaturezaDoPedidoRichTextBox.Text = ""
        '
        'NaturezaListBox
        '
        Me.NaturezaListBox.FormattingEnabled = True
        Me.NaturezaListBox.ItemHeight = 15
        Me.NaturezaListBox.Items.AddRange(New Object() {"Alvará de Localização Inicial", "Renovação do Alvará" & Global.Microsoft.VisualBasic.ChrW(9), "Mudança de Ramo", "Mudança de Endereço", "Alteração de Razão Social", "Renovação da Licença Sanitária", "Inclusão de Ramo", "Exclusão de Ramo", "Licença Sanitária para veículos", "Inscrição no Cadastro de Prestadores de Serviços sem Alvará de Localização", "Inclusão de Área", "Exclusão de Área"})
        Me.NaturezaListBox.Location = New System.Drawing.Point(349, 38)
        Me.NaturezaListBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NaturezaListBox.Name = "NaturezaListBox"
        Me.NaturezaListBox.Size = New System.Drawing.Size(282, 184)
        Me.NaturezaListBox.TabIndex = 33
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.GroupBox7)
        Me.TabPage13.Controls.Add(Me.GroupBox1)
        Me.TabPage13.Controls.Add(Me.TabControlAcompanhamento)
        Me.TabPage13.Location = New System.Drawing.Point(4, 24)
        Me.TabPage13.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage13.Size = New System.Drawing.Size(905, 309)
        Me.TabPage13.TabIndex = 1
        Me.TabPage13.Text = "Acompanhamento"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BtnContLigacao)
        Me.GroupBox7.Controls.Add(Me.BombeirosCheckBox)
        Me.GroupBox7.Controls.Add(Me.AmbientalCheckBox)
        Me.GroupBox7.Controls.Add(Me.ViabilidadeCheckBox)
        Me.GroupBox7.Controls.Add(Me.SanitarioCheckBox)
        Me.GroupBox7.Controls.Add(Me.SetranCheckBox)
        Me.GroupBox7.Location = New System.Drawing.Point(298, 250)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox7.Size = New System.Drawing.Size(590, 45)
        Me.GroupBox7.TabIndex = 35
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Controle de ligações"
        '
        'BtnContLigacao
        '
        Me.BtnContLigacao.BackgroundImage = CType(resources.GetObject("BtnContLigacao.BackgroundImage"), System.Drawing.Image)
        Me.BtnContLigacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnContLigacao.Location = New System.Drawing.Point(440, 13)
        Me.BtnContLigacao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnContLigacao.Name = "BtnContLigacao"
        Me.BtnContLigacao.Size = New System.Drawing.Size(139, 27)
        Me.BtnContLigacao.TabIndex = 58
        Me.BtnContLigacao.Text = "Controle de ligações"
        Me.BtnContLigacao.UseVisualStyleBackColor = True
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.BtnCadSite)
        Me.TabPage14.Controls.Add(Me.LinkLabel2)
        Me.TabPage14.Controls.Add(Me.BtnAnotacoesPref)
        Me.TabPage14.Controls.Add(Me.Button6)
        Me.TabPage14.Location = New System.Drawing.Point(4, 24)
        Me.TabPage14.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Size = New System.Drawing.Size(905, 309)
        Me.TabPage14.TabIndex = 2
        Me.TabPage14.Text = "Procedimento"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'BtnCadSite
        '
        Me.BtnCadSite.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnCadSite.BackgroundImage = CType(resources.GetObject("BtnCadSite.BackgroundImage"), System.Drawing.Image)
        Me.BtnCadSite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCadSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadSite.Location = New System.Drawing.Point(301, 25)
        Me.BtnCadSite.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCadSite.Name = "BtnCadSite"
        Me.BtnCadSite.Size = New System.Drawing.Size(181, 60)
        Me.BtnCadSite.TabIndex = 81
        Me.BtnCadSite.Text = "Cadastrar Sites"
        Me.BtnCadSite.UseVisualStyleBackColor = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(27, 204)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(372, 15)
        Me.LinkLabel2.TabIndex = 80
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Documentos necessários para Requerimento de Extravio de Alvará"
        '
        'BtnAnotacoesPref
        '
        Me.BtnAnotacoesPref.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnAnotacoesPref.BackgroundImage = CType(resources.GetObject("BtnAnotacoesPref.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoesPref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoesPref.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnotacoesPref.Location = New System.Drawing.Point(27, 92)
        Me.BtnAnotacoesPref.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAnotacoesPref.Name = "BtnAnotacoesPref"
        Me.BtnAnotacoesPref.Size = New System.Drawing.Size(181, 60)
        Me.BtnAnotacoesPref.TabIndex = 42
        Me.BtnAnotacoesPref.Text = "Anotações da Prefeitura em Geral"
        Me.BtnAnotacoesPref.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(27, 25)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(181, 60)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Procedimento da Prefeitura"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TabPage15
        '
        Me.TabPage15.AutoScroll = True
        Me.TabPage15.Controls.Add(Me.LinkLabel1)
        Me.TabPage15.Controls.Add(Me.PictureBox3)
        Me.TabPage15.Controls.Add(Me.GroupBoxProtocolo)
        Me.TabPage15.Location = New System.Drawing.Point(4, 24)
        Me.TabPage15.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage15.Size = New System.Drawing.Size(905, 309)
        Me.TabPage15.TabIndex = 3
        Me.TabPage15.Text = "Protocolo"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 276)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(372, 15)
        Me.LinkLabel1.TabIndex = 79
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Documentos necessários para Requerimento de Extravio de Alvará"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PrinceSistemas.My.Resources.Resources.protocolo11
        Me.PictureBox3.Location = New System.Drawing.Point(4, 7)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(204, 91)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 77
        Me.PictureBox3.TabStop = False
        '
        'GroupBoxProtocolo
        '
        Me.GroupBoxProtocolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBoxProtocolo.Controls.Add(Me.BtnAgoraProt)
        Me.GroupBoxProtocolo.Controls.Add(Me.LblProtocolo2)
        Me.GroupBoxProtocolo.Controls.Add(Me.LblProtocolo1)
        Me.GroupBoxProtocolo.Controls.Add(ReciboProcessoLabel)
        Me.GroupBoxProtocolo.Controls.Add(Me.BtnNovoProtocolo)
        Me.GroupBoxProtocolo.Controls.Add(ProtocoloSenhaLabel)
        Me.GroupBoxProtocolo.Controls.Add(Me.ReciboProcessoTextBox)
        Me.GroupBoxProtocolo.Controls.Add(Me.ProtocoloSenhaTextBox)
        Me.GroupBoxProtocolo.Controls.Add(Me.DataEntradaMaskedTextBox)
        Me.GroupBoxProtocolo.Controls.Add(Me.DataEntradaLabel)
        Me.GroupBoxProtocolo.Controls.Add(NumeroProcessoLabel)
        Me.GroupBoxProtocolo.Controls.Add(ProtocoloAnoLabel)
        Me.GroupBoxProtocolo.Controls.Add(Me.NumeroProcessoTextBox)
        Me.GroupBoxProtocolo.Controls.Add(Me.ProtocoloAnoTextBox)
        Me.GroupBoxProtocolo.Controls.Add(ProtocoloNLabel)
        Me.GroupBoxProtocolo.Controls.Add(Me.ProtocoloNTextBox)
        Me.GroupBoxProtocolo.Controls.Add(ProtocoloTipoLabel)
        Me.GroupBoxProtocolo.Controls.Add(Me.ProtocoloTipoTextBox)
        Me.GroupBoxProtocolo.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBoxProtocolo.Location = New System.Drawing.Point(215, 7)
        Me.GroupBoxProtocolo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxProtocolo.Name = "GroupBoxProtocolo"
        Me.GroupBoxProtocolo.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxProtocolo.Size = New System.Drawing.Size(652, 228)
        Me.GroupBoxProtocolo.TabIndex = 76
        Me.GroupBoxProtocolo.TabStop = False
        Me.GroupBoxProtocolo.Text = "Processo"
        '
        'BtnAgoraProt
        '
        Me.BtnAgoraProt.BackgroundImage = CType(resources.GetObject("BtnAgoraProt.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgoraProt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgoraProt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgoraProt.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnAgoraProt.Location = New System.Drawing.Point(234, 22)
        Me.BtnAgoraProt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAgoraProt.Name = "BtnAgoraProt"
        Me.BtnAgoraProt.Size = New System.Drawing.Size(80, 27)
        Me.BtnAgoraProt.TabIndex = 81
        Me.BtnAgoraProt.Text = "Agora"
        Me.BtnAgoraProt.UseVisualStyleBackColor = True
        '
        'LblProtocolo2
        '
        Me.LblProtocolo2.AutoSize = True
        Me.LblProtocolo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProtocolo2.Location = New System.Drawing.Point(7, 132)
        Me.LblProtocolo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProtocolo2.Name = "LblProtocolo2"
        Me.LblProtocolo2.Size = New System.Drawing.Size(100, 20)
        Me.LblProtocolo2.TabIndex = 80
        Me.LblProtocolo2.Text = "Protocolo 2"
        '
        'LblProtocolo1
        '
        Me.LblProtocolo1.AutoSize = True
        Me.LblProtocolo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProtocolo1.Location = New System.Drawing.Point(7, 60)
        Me.LblProtocolo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProtocolo1.Name = "LblProtocolo1"
        Me.LblProtocolo1.Size = New System.Drawing.Size(100, 20)
        Me.LblProtocolo1.TabIndex = 79
        Me.LblProtocolo1.Text = "Protocolo 1"
        '
        'BtnNovoProtocolo
        '
        Me.BtnNovoProtocolo.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnNovoProtocolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovoProtocolo.Location = New System.Drawing.Point(565, 20)
        Me.BtnNovoProtocolo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnNovoProtocolo.Name = "BtnNovoProtocolo"
        Me.BtnNovoProtocolo.Size = New System.Drawing.Size(80, 40)
        Me.BtnNovoProtocolo.TabIndex = 78
        Me.BtnNovoProtocolo.Text = "Novo Protocolo"
        Me.BtnNovoProtocolo.UseVisualStyleBackColor = True
        '
        'ReciboProcessoTextBox
        '
        Me.ReciboProcessoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ReciboProcesso", True))
        Me.ReciboProcessoTextBox.Location = New System.Drawing.Point(146, 192)
        Me.ReciboProcessoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ReciboProcessoTextBox.Name = "ReciboProcessoTextBox"
        Me.ReciboProcessoTextBox.Size = New System.Drawing.Size(254, 21)
        Me.ReciboProcessoTextBox.TabIndex = 3
        '
        'ProtocoloSenhaTextBox
        '
        Me.ProtocoloSenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ProtocoloSenha", True))
        Me.ProtocoloSenhaTextBox.Location = New System.Drawing.Point(420, 91)
        Me.ProtocoloSenhaTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ProtocoloSenhaTextBox.Name = "ProtocoloSenhaTextBox"
        Me.ProtocoloSenhaTextBox.Size = New System.Drawing.Size(116, 21)
        Me.ProtocoloSenhaTextBox.TabIndex = 75
        '
        'DataEntradaMaskedTextBox
        '
        Me.DataEntradaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "DataEntrada", True))
        Me.DataEntradaMaskedTextBox.Location = New System.Drawing.Point(111, 22)
        Me.DataEntradaMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataEntradaMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataEntradaMaskedTextBox.Name = "DataEntradaMaskedTextBox"
        Me.DataEntradaMaskedTextBox.Size = New System.Drawing.Size(116, 21)
        Me.DataEntradaMaskedTextBox.TabIndex = 66
        Me.DataEntradaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataEntradaLabel
        '
        Me.DataEntradaLabel.AutoSize = True
        Me.DataEntradaLabel.BackColor = System.Drawing.Color.Transparent
        Me.DataEntradaLabel.Location = New System.Drawing.Point(13, 28)
        Me.DataEntradaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DataEntradaLabel.Name = "DataEntradaLabel"
        Me.DataEntradaLabel.Size = New System.Drawing.Size(96, 15)
        Me.DataEntradaLabel.TabIndex = 71
        Me.DataEntradaLabel.Text = "Protocolado dia:"
        '
        'NumeroProcessoTextBox
        '
        Me.NumeroProcessoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "NumeroProcesso", True))
        Me.NumeroProcessoTextBox.Location = New System.Drawing.Point(146, 162)
        Me.NumeroProcessoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumeroProcessoTextBox.Name = "NumeroProcessoTextBox"
        Me.NumeroProcessoTextBox.Size = New System.Drawing.Size(254, 21)
        Me.NumeroProcessoTextBox.TabIndex = 1
        '
        'ProtocoloAnoTextBox
        '
        Me.ProtocoloAnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ProtocoloAno", True))
        Me.ProtocoloAnoTextBox.Location = New System.Drawing.Point(287, 91)
        Me.ProtocoloAnoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ProtocoloAnoTextBox.Name = "ProtocoloAnoTextBox"
        Me.ProtocoloAnoTextBox.Size = New System.Drawing.Size(70, 21)
        Me.ProtocoloAnoTextBox.TabIndex = 74
        '
        'ProtocoloNTextBox
        '
        Me.ProtocoloNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ProtocoloN", True))
        Me.ProtocoloNTextBox.Location = New System.Drawing.Point(141, 91)
        Me.ProtocoloNTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ProtocoloNTextBox.Name = "ProtocoloNTextBox"
        Me.ProtocoloNTextBox.Size = New System.Drawing.Size(97, 21)
        Me.ProtocoloNTextBox.TabIndex = 73
        '
        'ProtocoloTipoTextBox
        '
        Me.ProtocoloTipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "ProtocoloTipo", True))
        Me.ProtocoloTipoTextBox.Location = New System.Drawing.Point(56, 91)
        Me.ProtocoloTipoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ProtocoloTipoTextBox.Name = "ProtocoloTipoTextBox"
        Me.ProtocoloTipoTextBox.Size = New System.Drawing.Size(45, 21)
        Me.ProtocoloTipoTextBox.TabIndex = 72
        '
        'TabPage16
        '
        Me.TabPage16.Controls.Add(HistoricoLabel)
        Me.TabPage16.Controls.Add(Me.HistoricoRichTextBox)
        Me.TabPage16.Location = New System.Drawing.Point(4, 24)
        Me.TabPage16.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Size = New System.Drawing.Size(905, 309)
        Me.TabPage16.TabIndex = 4
        Me.TabPage16.Text = "Histórico"
        Me.TabPage16.UseVisualStyleBackColor = True
        '
        'HistoricoRichTextBox
        '
        Me.HistoricoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Historico", True))
        Me.HistoricoRichTextBox.Location = New System.Drawing.Point(13, 35)
        Me.HistoricoRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HistoricoRichTextBox.Name = "HistoricoRichTextBox"
        Me.HistoricoRichTextBox.Size = New System.Drawing.Size(807, 249)
        Me.HistoricoRichTextBox.TabIndex = 1
        Me.HistoricoRichTextBox.Text = ""
        '
        'ButtonSolicitar
        '
        Me.ButtonSolicitar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonSolicitar.BackgroundImage = CType(resources.GetObject("ButtonSolicitar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSolicitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSolicitar.Location = New System.Drawing.Point(337, 81)
        Me.ButtonSolicitar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonSolicitar.Name = "ButtonSolicitar"
        Me.ButtonSolicitar.Size = New System.Drawing.Size(91, 28)
        Me.ButtonSolicitar.TabIndex = 51
        Me.ButtonSolicitar.Text = "Solicitar"
        Me.ButtonSolicitar.UseVisualStyleBackColor = False
        '
        'BtnAnotacoesLEgalizacao
        '
        Me.BtnAnotacoesLEgalizacao.BackgroundImage = CType(resources.GetObject("BtnAnotacoesLEgalizacao.BackgroundImage"), System.Drawing.Image)
        Me.BtnAnotacoesLEgalizacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnotacoesLEgalizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnotacoesLEgalizacao.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnAnotacoesLEgalizacao.Location = New System.Drawing.Point(7, 92)
        Me.BtnAnotacoesLEgalizacao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAnotacoesLEgalizacao.Name = "BtnAnotacoesLEgalizacao"
        Me.BtnAnotacoesLEgalizacao.Size = New System.Drawing.Size(80, 27)
        Me.BtnAnotacoesLEgalizacao.TabIndex = 80
        Me.BtnAnotacoesLEgalizacao.Text = "Anotações"
        Me.BtnAnotacoesLEgalizacao.UseVisualStyleBackColor = True
        '
        'CMCTextBox
        '
        Me.CMCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "CMC", True))
        Me.CMCTextBox.Location = New System.Drawing.Point(462, 74)
        Me.CMCTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CMCTextBox.Name = "CMCTextBox"
        Me.CMCTextBox.Size = New System.Drawing.Size(83, 21)
        Me.CMCTextBox.TabIndex = 40
        '
        'Button14
        '
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button14.Location = New System.Drawing.Point(7, 203)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(80, 27)
        Me.Button14.TabIndex = 56
        Me.Button14.Text = "Contador"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button13.Location = New System.Drawing.Point(7, 237)
        Me.Button13.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(80, 27)
        Me.Button13.TabIndex = 55
        Me.Button13.Text = "Telefones"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSize = True
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Controls.Add(Me.BtnCopiarRegistro)
        Me.GroupBox5.Controls.Add(Me.BtnEditar)
        Me.GroupBox5.Controls.Add(Me.BtnNovo)
        Me.GroupBox5.Controls.Add(Me.BtnSalvar)
        Me.GroupBox5.Controls.Add(Me.Button17)
        Me.GroupBox5.Controls.Add(Me.Button19)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(914, 3)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox5.Size = New System.Drawing.Size(93, 239)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MENU"
        '
        'BtnCopiarRegistro
        '
        Me.BtnCopiarRegistro.BackgroundImage = CType(resources.GetObject("BtnCopiarRegistro.BackgroundImage"), System.Drawing.Image)
        Me.BtnCopiarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCopiarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiarRegistro.Location = New System.Drawing.Point(7, 117)
        Me.BtnCopiarRegistro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCopiarRegistro.Name = "BtnCopiarRegistro"
        Me.BtnCopiarRegistro.Size = New System.Drawing.Size(80, 27)
        Me.BtnCopiarRegistro.TabIndex = 78
        Me.BtnCopiarRegistro.Text = "Copiar"
        Me.BtnCopiarRegistro.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.BackgroundImage = CType(resources.GetObject("BtnEditar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(7, 85)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(80, 27)
        Me.BtnEditar.TabIndex = 77
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnNovaAlteracao
        '
        Me.BtnNovaAlteracao.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.BtnNovaAlteracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovaAlteracao.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnNovaAlteracao.Location = New System.Drawing.Point(7, 14)
        Me.BtnNovaAlteracao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnNovaAlteracao.Name = "BtnNovaAlteracao"
        Me.BtnNovaAlteracao.Size = New System.Drawing.Size(80, 52)
        Me.BtnNovaAlteracao.TabIndex = 76
        Me.BtnNovaAlteracao.Text = "Nova Alteração"
        Me.BtnNovaAlteracao.UseVisualStyleBackColor = True
        '
        'Btnempresa
        '
        Me.Btnempresa.BackgroundImage = CType(resources.GetObject("Btnempresa.BackgroundImage"), System.Drawing.Image)
        Me.Btnempresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnempresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnempresa.ForeColor = System.Drawing.Color.MediumBlue
        Me.Btnempresa.Location = New System.Drawing.Point(7, 170)
        Me.Btnempresa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btnempresa.Name = "Btnempresa"
        Me.Btnempresa.Size = New System.Drawing.Size(80, 27)
        Me.Btnempresa.TabIndex = 57
        Me.Btnempresa.Text = "Empresas"
        Me.Btnempresa.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(214, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Empresa:"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.FundoBotaoNormalNovo1
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(223, 73)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(71, 25)
        Me.Button12.TabIndex = 60
        Me.Button12.Text = "Consultar"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundoColoridoBotao
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(301, 73)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(54, 25)
        Me.Button15.TabIndex = 61
        Me.Button15.Text = "Copiar"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'AvisarDiaMaskedTextBox
        '
        Me.AvisarDiaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "AvisarDia", True))
        Me.AvisarDiaMaskedTextBox.Location = New System.Drawing.Point(90, 134)
        Me.AvisarDiaMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AvisarDiaMaskedTextBox.Mask = "00/00/0000"
        Me.AvisarDiaMaskedTextBox.Name = "AvisarDiaMaskedTextBox"
        Me.AvisarDiaMaskedTextBox.Size = New System.Drawing.Size(75, 21)
        Me.AvisarDiaMaskedTextBox.TabIndex = 70
        Me.AvisarDiaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DataCriadoMaskedTextBox
        '
        Me.DataCriadoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "DataCriado", True))
        Me.DataCriadoMaskedTextBox.Location = New System.Drawing.Point(90, 104)
        Me.DataCriadoMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataCriadoMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DataCriadoMaskedTextBox.Name = "DataCriadoMaskedTextBox"
        Me.DataCriadoMaskedTextBox.Size = New System.Drawing.Size(116, 21)
        Me.DataCriadoMaskedTextBox.TabIndex = 68
        Me.DataCriadoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PrinceSistemas.My.Resources.Resources.alvara1
        Me.PictureBox1.Location = New System.Drawing.Point(4, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PrinceSistemas.My.Resources.Resources.Fundo
        Me.PictureBox2.Location = New System.Drawing.Point(94, -3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(623, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'CMCLabel
        '
        Me.CMCLabel.AutoSize = True
        Me.CMCLabel.BackColor = System.Drawing.Color.Transparent
        Me.CMCLabel.Location = New System.Drawing.Point(424, 79)
        Me.CMCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CMCLabel.Name = "CMCLabel"
        Me.CMCLabel.Size = New System.Drawing.Size(37, 15)
        Me.CMCLabel.TabIndex = 75
        Me.CMCLabel.TabStop = True
        Me.CMCLabel.Text = "CMC:"
        '
        'CheckBoxPrioridade
        '
        Me.CheckBoxPrioridade.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPrioridade.Controls.Add(MatrizLabel)
        Me.CheckBoxPrioridade.Controls.Add(Me.BtnFiliais)
        Me.CheckBoxPrioridade.Controls.Add(Me.MatrizComboBox)
        Me.CheckBoxPrioridade.Controls.Add(Me.LabelFilial)
        Me.CheckBoxPrioridade.Controls.Add(Me.PrioridadeCheckBox)
        Me.CheckBoxPrioridade.Controls.Add(Me.BtnVerificar)
        Me.CheckBoxPrioridade.Controls.Add(Me.BtnMgsBoxAvisarDia)
        Me.CheckBoxPrioridade.Controls.Add(Me.LembreteCheckBox)
        Me.CheckBoxPrioridade.Controls.Add(Me.CNPJLabel)
        Me.CheckBoxPrioridade.Controls.Add(Me.SituacaoComboBox)
        Me.CheckBoxPrioridade.Controls.Add(EndEstadoLabel1)
        Me.CheckBoxPrioridade.Controls.Add(Me.EndEstadoLabel2)
        Me.CheckBoxPrioridade.Controls.Add(Me.PictureBox1)
        Me.CheckBoxPrioridade.Controls.Add(Me.PictureBox2)
        Me.CheckBoxPrioridade.Controls.Add(Me.EndCidadeLabel2)
        Me.CheckBoxPrioridade.Controls.Add(EndCidadeLabel1)
        Me.CheckBoxPrioridade.Controls.Add(Me.BtnData1)
        Me.CheckBoxPrioridade.Controls.Add(Me.CMCLabel)
        Me.CheckBoxPrioridade.Controls.Add(AvisarDiaLabel)
        Me.CheckBoxPrioridade.Controls.Add(Me.AvisarDiaMaskedTextBox)
        Me.CheckBoxPrioridade.Controls.Add(Me.CMCTextBox)
        Me.CheckBoxPrioridade.Controls.Add(DataCriadoLabel)
        Me.CheckBoxPrioridade.Controls.Add(Me.DataCriadoMaskedTextBox)
        Me.CheckBoxPrioridade.Controls.Add(Me.Button15)
        Me.CheckBoxPrioridade.Controls.Add(Me.Button12)
        Me.CheckBoxPrioridade.Controls.Add(SituacaoLabel)
        Me.CheckBoxPrioridade.Controls.Add(Me.CNPJMaskedTextBox)
        Me.CheckBoxPrioridade.Controls.Add(RazaoSocialLabel)
        Me.CheckBoxPrioridade.Controls.Add(Me.RazaoSocialTextBox)
        Me.CheckBoxPrioridade.Location = New System.Drawing.Point(5, 13)
        Me.CheckBoxPrioridade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckBoxPrioridade.Name = "CheckBoxPrioridade"
        Me.CheckBoxPrioridade.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckBoxPrioridade.Size = New System.Drawing.Size(694, 185)
        Me.CheckBoxPrioridade.TabIndex = 78
        Me.CheckBoxPrioridade.TabStop = False
        '
        'BtnFiliais
        '
        Me.BtnFiliais.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnFiliais.BackgroundImage = CType(resources.GetObject("BtnFiliais.BackgroundImage"), System.Drawing.Image)
        Me.BtnFiliais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFiliais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFiliais.Location = New System.Drawing.Point(594, 42)
        Me.BtnFiliais.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFiliais.Name = "BtnFiliais"
        Me.BtnFiliais.Size = New System.Drawing.Size(83, 25)
        Me.BtnFiliais.TabIndex = 84
        Me.BtnFiliais.Text = "Filiais"
        Me.BtnFiliais.UseVisualStyleBackColor = False
        '
        'MatrizComboBox
        '
        Me.MatrizComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Matriz", True))
        Me.MatrizComboBox.FormattingEnabled = True
        Me.MatrizComboBox.Items.AddRange(New Object() {"Matriz", "Filial 1", "Filial 2", "Filial 3", "Filial 4", "Filial 5", "Filial 6", "Filial 7", "Filial 8", "Filial 9", "Filial 10"})
        Me.MatrizComboBox.Location = New System.Drawing.Point(594, 75)
        Me.MatrizComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MatrizComboBox.Name = "MatrizComboBox"
        Me.MatrizComboBox.Size = New System.Drawing.Size(93, 23)
        Me.MatrizComboBox.TabIndex = 58
        '
        'LabelFilial
        '
        Me.LabelFilial.AutoSize = True
        Me.LabelFilial.Location = New System.Drawing.Point(597, 47)
        Me.LabelFilial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFilial.Name = "LabelFilial"
        Me.LabelFilial.Size = New System.Drawing.Size(69, 30)
        Me.LabelFilial.TabIndex = 85
        Me.LabelFilial.Text = "Filial não" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "encontrada"
        '
        'PrioridadeCheckBox
        '
        Me.PrioridadeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LaudosBindingSource, "Prioridade", True))
        Me.PrioridadeCheckBox.Location = New System.Drawing.Point(173, 157)
        Me.PrioridadeCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PrioridadeCheckBox.Name = "PrioridadeCheckBox"
        Me.PrioridadeCheckBox.Size = New System.Drawing.Size(85, 28)
        Me.PrioridadeCheckBox.TabIndex = 58
        Me.PrioridadeCheckBox.Text = "Prioridade"
        Me.PrioridadeCheckBox.UseVisualStyleBackColor = True
        '
        'BtnVerificar
        '
        Me.BtnVerificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnVerificar.BackgroundImage = CType(resources.GetObject("BtnVerificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificar.Location = New System.Drawing.Point(360, 73)
        Me.BtnVerificar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnVerificar.Name = "BtnVerificar"
        Me.BtnVerificar.Size = New System.Drawing.Size(62, 25)
        Me.BtnVerificar.TabIndex = 83
        Me.BtnVerificar.Text = "Verificar"
        Me.BtnVerificar.UseVisualStyleBackColor = False
        '
        'BtnMgsBoxAvisarDia
        '
        Me.BtnMgsBoxAvisarDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMgsBoxAvisarDia.Location = New System.Drawing.Point(226, 133)
        Me.BtnMgsBoxAvisarDia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnMgsBoxAvisarDia.Name = "BtnMgsBoxAvisarDia"
        Me.BtnMgsBoxAvisarDia.Size = New System.Drawing.Size(93, 23)
        Me.BtnMgsBoxAvisarDia.TabIndex = 82
        Me.BtnMgsBoxAvisarDia.Text = "Verificar Data"
        Me.BtnMgsBoxAvisarDia.UseVisualStyleBackColor = True
        '
        'LembreteCheckBox
        '
        Me.LembreteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LaudosBindingSource, "Lembrete", True))
        Me.LembreteCheckBox.Location = New System.Drawing.Point(90, 157)
        Me.LembreteCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LembreteCheckBox.Name = "LembreteCheckBox"
        Me.LembreteCheckBox.Size = New System.Drawing.Size(121, 28)
        Me.LembreteCheckBox.TabIndex = 81
        Me.LembreteCheckBox.Text = "Lembrete"
        Me.LembreteCheckBox.UseVisualStyleBackColor = True
        '
        'CNPJLabel
        '
        Me.CNPJLabel.AutoSize = True
        Me.CNPJLabel.Location = New System.Drawing.Point(44, 78)
        Me.CNPJLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CNPJLabel.Name = "CNPJLabel"
        Me.CNPJLabel.Size = New System.Drawing.Size(41, 15)
        Me.CNPJLabel.TabIndex = 79
        Me.CNPJLabel.Text = "CNPJ:"
        '
        'SituacaoComboBox
        '
        Me.SituacaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SituacaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "Situacao", True))
        Me.SituacaoComboBox.FormattingEnabled = True
        Me.SituacaoComboBox.Location = New System.Drawing.Point(334, 104)
        Me.SituacaoComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SituacaoComboBox.Name = "SituacaoComboBox"
        Me.SituacaoComboBox.Size = New System.Drawing.Size(241, 23)
        Me.SituacaoComboBox.TabIndex = 78
        '
        'EndEstadoLabel2
        '
        Me.EndEstadoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndEstado", True))
        Me.EndEstadoLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndEstadoLabel2.Location = New System.Drawing.Point(387, 158)
        Me.EndEstadoLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EndEstadoLabel2.Name = "EndEstadoLabel2"
        Me.EndEstadoLabel2.Size = New System.Drawing.Size(159, 17)
        Me.EndEstadoLabel2.TabIndex = 77
        '
        'EndCidadeLabel2
        '
        Me.EndCidadeLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EndCidadeLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaudosBindingSource, "EndCidade", True))
        Me.EndCidadeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndCidadeLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EndCidadeLabel2.Location = New System.Drawing.Point(388, 134)
        Me.EndCidadeLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EndCidadeLabel2.Name = "EndCidadeLabel2"
        Me.EndCidadeLabel2.Size = New System.Drawing.Size(158, 21)
        Me.EndCidadeLabel2.TabIndex = 76
        '
        'BtnData1
        '
        Me.BtnData1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnData1.Location = New System.Drawing.Point(173, 133)
        Me.BtnData1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnData1.Name = "BtnData1"
        Me.BtnData1.Size = New System.Drawing.Size(50, 24)
        Me.BtnData1.TabIndex = 76
        Me.BtnData1.Text = "Agora"
        Me.BtnData1.UseVisualStyleBackColor = True
        '
        'CADSituacaoAlvaraTableAdapter
        '
        Me.CADSituacaoAlvaraTableAdapter.ClearBeforeFill = True
        '
        'BtnLocalizar
        '
        Me.BtnLocalizar.BackgroundImage = CType(resources.GetObject("BtnLocalizar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLocalizar.Location = New System.Drawing.Point(816, 0)
        Me.BtnLocalizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnLocalizar.Name = "BtnLocalizar"
        Me.BtnLocalizar.Size = New System.Drawing.Size(80, 23)
        Me.BtnLocalizar.TabIndex = 80
        Me.BtnLocalizar.Text = "Localizar"
        Me.BtnLocalizar.UseVisualStyleBackColor = True
        '
        'ComboBoxBuscaCNPJ
        '
        Me.ComboBoxBuscaCNPJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBuscaCNPJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBuscaCNPJ.DataSource = Me.LaudosBindingSource
        Me.ComboBoxBuscaCNPJ.DisplayMember = "CNPJ"
        Me.ComboBoxBuscaCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxBuscaCNPJ.FormattingEnabled = True
        Me.ComboBoxBuscaCNPJ.Location = New System.Drawing.Point(652, 1)
        Me.ComboBoxBuscaCNPJ.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBoxBuscaCNPJ.Name = "ComboBoxBuscaCNPJ"
        Me.ComboBoxBuscaCNPJ.Size = New System.Drawing.Size(148, 23)
        Me.ComboBoxBuscaCNPJ.TabIndex = 81
        Me.ComboBoxBuscaCNPJ.ValueMember = "CNPJ"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.00989!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.990108!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox10, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxCima, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1011, 752)
        Me.TableLayoutPanel1.TabIndex = 82
        '
        'GroupBox10
        '
        Me.GroupBox10.AutoSize = True
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.GroupBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox10.Controls.Add(Me.BtnExportarWord)
        Me.GroupBox10.Controls.Add(Me.BtnAnotacoesLEgalizacao)
        Me.GroupBox10.Controls.Add(Me.Btnempresa)
        Me.GroupBox10.Controls.Add(Me.BtnNovaAlteracao)
        Me.GroupBox10.Controls.Add(Me.Button14)
        Me.GroupBox10.Controls.Add(Me.Button13)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.Location = New System.Drawing.Point(914, 248)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox10.Size = New System.Drawing.Size(93, 501)
        Me.GroupBox10.TabIndex = 58
        Me.GroupBox10.TabStop = False
        '
        'BtnExportarWord
        '
        Me.BtnExportarWord.BackgroundImage = CType(resources.GetObject("BtnExportarWord.BackgroundImage"), System.Drawing.Image)
        Me.BtnExportarWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExportarWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportarWord.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnExportarWord.Location = New System.Drawing.Point(7, 126)
        Me.BtnExportarWord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnExportarWord.Name = "BtnExportarWord"
        Me.BtnExportarWord.Size = New System.Drawing.Size(80, 27)
        Me.BtnExportarWord.TabIndex = 81
        Me.BtnExportarWord.Text = "WORD"
        Me.BtnExportarWord.UseVisualStyleBackColor = True
        '
        'GroupBoxCima
        '
        Me.GroupBoxCima.AutoSize = True
        Me.GroupBoxCima.Controls.Add(Me.CheckBoxPrioridade)
        Me.GroupBoxCima.Controls.Add(Me.GroupBox3)
        Me.GroupBoxCima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxCima.Location = New System.Drawing.Point(4, 3)
        Me.GroupBoxCima.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxCima.Name = "GroupBoxCima"
        Me.GroupBoxCima.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxCima.Size = New System.Drawing.Size(902, 239)
        Me.GroupBoxCima.TabIndex = 0
        Me.GroupBoxCima.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Silver
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(573, 6)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 15)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "CPF/CNPJ:"
        '
        'BombeiroSituacaoBindingSource
        '
        Me.BombeiroSituacaoBindingSource.DataMember = "BombeiroSituacao"
        Me.BombeiroSituacaoBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'BombeiroSituacaoTableAdapter
        '
        Me.BombeiroSituacaoTableAdapter.ClearBeforeFill = True
        '
        'AlvaraSistemaBindingSource
        '
        Me.AlvaraSistemaBindingSource.DataMember = "AlvaraSistema"
        Me.AlvaraSistemaBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'AlvaraSistemaTableAdapter
        '
        Me.AlvaraSistemaTableAdapter.ClearBeforeFill = True
        '
        'FrmAlvara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = Global.PrinceSistemas.My.Resources.Resources.fundo_azul
        Me.ClientSize = New System.Drawing.Size(1011, 777)
        Me.Controls.Add(Me.ComboBoxBuscaCNPJ)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BtnLocalizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxBuscaAlvara)
        Me.Controls.Add(Me.LaudosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmAlvara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Alvará"
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaudosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LaudosBindingNavigator.ResumeLayout(False)
        Me.LaudosBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControlAcompanhamento.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBoxDatProvBombeiro.ResumeLayout(False)
        Me.GroupBoxDatProvBombeiro.PerformLayout()
        CType(Me.ButtonApagaDataBombeiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonAddDataBombeiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBoxDatProvAmbiental.ResumeLayout(False)
        Me.GroupBoxDatProvAmbiental.PerformLayout()
        CType(Me.ButtonAddDataAmbiental, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonApagaDataAmbiental, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBoxDatProvViabilidade.ResumeLayout(False)
        Me.GroupBoxDatProvViabilidade.PerformLayout()
        CType(Me.ButtonAddDataViabilidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonApagaDataViabilidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBoxDatProvSanitario.ResumeLayout(False)
        Me.GroupBoxDatProvSanitario.PerformLayout()
        CType(Me.ButtonAddDataSanitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonApagaDataSanitario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBoxDatProvSetran.ResumeLayout(False)
        Me.GroupBoxDatProvSetran.PerformLayout()
        CType(Me.ButtonAddDataSetran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonApagaDataSetran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CADSituacaoAlvaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabAlvara.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.TabPage14.ResumeLayout(False)
        Me.TabPage14.PerformLayout()
        Me.TabPage15.ResumeLayout(False)
        Me.TabPage15.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProtocolo.ResumeLayout(False)
        Me.GroupBoxProtocolo.PerformLayout()
        Me.TabPage16.ResumeLayout(False)
        Me.TabPage16.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CheckBoxPrioridade.ResumeLayout(False)
        Me.CheckBoxPrioridade.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBoxCima.ResumeLayout(False)
        Me.GroupBoxCima.PerformLayout()
        CType(Me.BombeiroSituacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlvaraSistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents LaudosBindingSource As BindingSource
    Friend WithEvents LaudosTableAdapter As PrinceDBDataSetTableAdapters.LaudosTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LaudosBindingNavigator As BindingNavigator
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
    Friend WithEvents CNPJMaskedTextBox As MaskedTextBox
    Friend WithEvents BombeirosCheckBox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SetranSituacaoComboBox As ComboBox
    Friend WithEvents SetranCheckBox As CheckBox
    Friend WithEvents SanitarioSituacaoComboBox As ComboBox
    Friend WithEvents SanitarioCheckBox As CheckBox
    Friend WithEvents ViabilidadeSituacaoComboBox As ComboBox
    Friend WithEvents ViabilidadeCheckBox As CheckBox
    Friend WithEvents AmbientalSituacaoComboBox As ComboBox
    Friend WithEvents AmbientalCheckBox As CheckBox
    Friend WithEvents TabControlAcompanhamento As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents BombeiroDataPedProcessoMaskedTextBox As MaskedTextBox
    Friend WithEvents BombeiroNProcessoMaskedTextBox As MaskedTextBox
    Friend WithEvents BombeiroExigenciaRichTextBox As RichTextBox
    Friend WithEvents AmbientalExigenciaRichTextBox As RichTextBox
    Friend WithEvents ViabilidadeExigenciaRichTextBox As RichTextBox
    Friend WithEvents SanitarioExigenciaRichTextBox As RichTextBox
    Friend WithEvents SetranExigenciaRichTextBox As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NlaudoTextBox As TextBox
    Friend WithEvents ModeloSistemaComboBox As ComboBox
    Friend WithEvents ButtonConsultar As Button
    Friend WithEvents ComboBoxBuscaAlvara As ComboBox
    Friend WithEvents BtnCalendarioWindows As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button20 As Button
    Friend WithEvents Sanitariocontrole3TextBox As TextBox
    Friend WithEvents Sanitariocontrole2TextBox As TextBox
    Friend WithEvents Sanitariocontrole1TextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonSolicitar As Button
    Friend WithEvents DataEntradaLabel As Label
    Friend WithEvents AvisarDiaMaskedTextBox As MaskedTextBox
    Friend WithEvents DataEntradaMaskedTextBox As MaskedTextBox
    Friend WithEvents DataCriadoMaskedTextBox As MaskedTextBox
    Friend WithEvents Btnempresa As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabAlvara As TabControl
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents TabPage14 As TabPage
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents NaturezaDoPedidoOBSRichTextBox As RichTextBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Button21 As Button
    Friend WithEvents Area2TextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents CadImobTextBox As TextBox
    Friend WithEvents CMCTextBox As TextBox
    Friend WithEvents EndDataTextBox As TextBox
    Friend WithEvents EndQuadraTextBox As TextBox
    Friend WithEvents EndZonaTextBox As TextBox
    Friend WithEvents EndNumTextBox As TextBox
    Friend WithEvents EndEstadoTextBox As TextBox
    Friend WithEvents EndCEPMaskedTextBox As MaskedTextBox
    Friend WithEvents Button22 As Button
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents ResptecnicoTextBox As TextBox
    Friend WithEvents ResptecnicoNumeroTextBox As TextBox
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents RamodeatividadeRichTextBox As RichTextBox
    Friend WithEvents CNAERichTextBox As RichTextBox
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button23 As Button
    Friend WithEvents CNPJRequerenteMaskedTextBox As MaskedTextBox
    Friend WithEvents RGRequerenteTextBox As TextBox
    Friend WithEvents CPFRequerenteMaskedTextBox As MaskedTextBox
    Friend WithEvents EmailRequerenteTextBox As TextBox
    Friend WithEvents FoneRequerenteTextBox As TextBox
    Friend WithEvents EndRequerenteTextBox As TextBox
    Friend WithEvents RequerenteTextBox As TextBox
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents Button25 As Button
    Friend WithEvents NaturezaDoPedidoRichTextBox As RichTextBox
    Friend WithEvents NaturezaListBox As ListBox
    Friend WithEvents CMCLabel As LinkLabel
    Friend WithEvents TabPage15 As TabPage
    Friend WithEvents ProtocoloSenhaTextBox As TextBox
    Friend WithEvents ProtocoloAnoTextBox As TextBox
    Friend WithEvents ProtocoloNTextBox As TextBox
    Friend WithEvents ProtocoloTipoTextBox As TextBox
    Friend WithEvents BtnAtualizarDados As Button
    Friend WithEvents TabPage16 As TabPage
    Friend WithEvents HistoricoRichTextBox As RichTextBox
    Friend WithEvents BtnNovaAlteracao As Button
    Friend WithEvents BombeiroSituacaoComboBox As ComboBox
    Friend WithEvents BtnBombVer As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents CheckBoxPrioridade As GroupBox
    Friend WithEvents GroupBoxProtocolo As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NlaudoLabel As Label
    Friend WithEvents BtnNovoProtocolo As Button
    Friend WithEvents BtnProcotBomb As Button
    Friend WithEvents BtnData1 As Button
    Friend WithEvents EndCidadeLabel2 As Label
    Friend WithEvents EndEstadoLabel2 As Label
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents BtnAnotacoes As Button
    Friend WithEvents BtnContLigacao As Button
    Friend WithEvents CADSituacaoAlvaraBindingSource As BindingSource
    Friend WithEvents CADSituacaoAlvaraTableAdapter As PrinceDBDataSetTableAdapters.CADSituacaoAlvaraTableAdapter
    Friend WithEvents BtnAnotacoesPref As Button
    Friend WithEvents BtnAnotacoesLEgalizacao As Button
    Friend WithEvents SituacaoComboBox As ComboBox
    Friend WithEvents BombeiroProvisorioDATAMaskedTextBox As MaskedTextBox
    Friend WithEvents AmbientalProvisorioDATAMaskedTextBox As MaskedTextBox
    Friend WithEvents ViabilidadeProvisorioDATAMaskedTextBox As MaskedTextBox
    Friend WithEvents SanitarioProvisorioDATAMaskedTextBox As MaskedTextBox
    Friend WithEvents SetranProvisorioDATAMaskedTextBox As MaskedTextBox
    Friend WithEvents CNPJLabel As Label
    Friend WithEvents ObservacaoRichTextBox As RichTextBox
    Friend WithEvents ButtonApagaDataBombeiro As PictureBox
    Friend WithEvents ButtonApagaDataAmbiental As PictureBox
    Friend WithEvents ButtonApagaDataViabilidade As PictureBox
    Friend WithEvents ButtonApagaDataSanitario As PictureBox
    Friend WithEvents ButtonApagaDataSetran As PictureBox
    Friend WithEvents BtnLocalizar As Button
    Friend WithEvents ComboBoxBuscaCNPJ As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxCima As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ButtonAddDataBombeiro As PictureBox
    Friend WithEvents ButtonAddDataAmbiental As PictureBox
    Friend WithEvents ButtonAddDataViabilidade As PictureBox
    Friend WithEvents ButtonAddDataSanitario As PictureBox
    Friend WithEvents ButtonAddDataSetran As PictureBox
    Friend WithEvents GroupBoxDatProvBombeiro As GroupBox
    Friend WithEvents GroupBoxDatProvAmbiental As GroupBox
    Friend WithEvents GroupBoxDatProvViabilidade As GroupBox
    Friend WithEvents GroupBoxDatProvSanitario As GroupBox
    Friend WithEvents GroupBoxDatProvSetran As GroupBox
    Friend WithEvents ToolTipMostraDescricao As ToolTip
    Friend WithEvents LabelBombeiroDataProvisorio As Label
    Friend WithEvents LabelAmbientalDataProvisorio As Label
    Friend WithEvents LabelSetranDataProvisorio As Label
    Friend WithEvents LabelSanitarioDataProvisorio As Label
    Friend WithEvents LabelViabilidadeDataProvisorio As Label
    Friend WithEvents LembreteCheckBox As CheckBox
    Friend WithEvents PontoRefTextBox As TextBox
    Friend WithEvents EndBairroTextBox As TextBox
    Friend WithEvents EndCompTextBox As TextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents EndCidadeTextBox As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents BtnMgsBoxAvisarDia As Button
    Friend WithEvents BtnExportarWord As Button
    Friend WithEvents EstadoOrgaoRGRequerenteTextBox As TextBox
    Friend WithEvents OrgaoRGRequerenteTextBox As TextBox
    Friend WithEvents ReciboProcessoTextBox As TextBox
    Friend WithEvents NumeroProcessoTextBox As TextBox
    Friend WithEvents BtnImportaSocio As Button
    Friend WithEvents LblProtocolo2 As Label
    Friend WithEvents LblProtocolo1 As Label
    Friend WithEvents BtnVerificar As Button
    Friend WithEvents BtnMapa As Button
    Friend WithEvents BtnCopiaCEP As Button
    Friend WithEvents PrioridadeCheckBox As CheckBox
    Friend WithEvents BtnAgoraProt As Button
    Friend WithEvents BtnGrauDeRisco As Button
    Friend WithEvents BtnFiliais As Button
    Friend WithEvents LabelFilial As Label
    Friend WithEvents MatrizComboBox As ComboBox
    Friend WithEvents BombeiroDataMultaMaskedTextBox As MaskedTextBox
    Friend WithEvents BtnMultaBombeiro As Button
    Friend WithEvents LabelBombeiroMulta As Label
    Friend WithEvents BtnVerObsGeral As Button
    Friend WithEvents BombeiroSituacaoBindingSource As BindingSource
    Friend WithEvents BombeiroSituacaoTableAdapter As PrinceDBDataSetTableAdapters.BombeiroSituacaoTableAdapter
    Friend WithEvents AlvaraSistemaBindingSource As BindingSource
    Friend WithEvents AlvaraSistemaTableAdapter As PrinceDBDataSetTableAdapters.AlvaraSistemaTableAdapter
    Friend WithEvents BtnCopiarRegistro As Button
    Friend WithEvents BtnCadSite As Button
    Friend WithEvents NlaudoSecundarioTextBox As TextBox
End Class
