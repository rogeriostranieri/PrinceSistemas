﻿Module ModCombobox
    '=============================================================================
    '=============================================================================
    '======================== ALVARÁ  ===================================
    '=============================================================================
    '=============================================================================

    'Combobox Alvará ref a situação
    Sub ComboboxAlvara()
        ' chamar usa  =>         ModCombobox.ComboboxAlvara()

        'StatusComboBox
        '
        FrmAlvara.SituacaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        FrmAlvara.SituacaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        ' FrmAlvara.SituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", FrmAlvara.alvaraBindingSource, "Status", True))
        FrmAlvara.SituacaoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        FrmAlvara.SituacaoComboBox.FormattingEnabled = True
        FrmAlvara.SituacaoComboBox.Items.AddRange(New Object() {"Aguardando Cliente", "Aguardando Pagamento", "Aguardando Prefeitura", "Baixado", "Cadastro desatualizado", "Cancelado", "Em Andamento", "Finalizado Definitivo", "Finalizado Provisório", "Não Fazer", "Não Iniciado", "Paralisado", "Pendência", "Protocolado", "Saiu do Escritório"})
        ' FrmAlvara.SituacaoComboBox.Location = New System.Drawing.Point(421, 14)
        'FrmAlvara.SituacaoComboBox.Name = "StatusComboBox"
        ' FrmAlvara.SituacaoComboBox.Size = New System.Drawing.Size(207, 21)
        '  FrmAlvara.SituacaoComboBox.TabIndex = 10
        '
    End Sub

    'relatorio alvará

    Sub ComboboxRelatorioAlvara()
        ' chamar usa  =>         ModCombobox.ComboboxAlvara()

        'StatusComboBox
        '
        '  RelatorioLaudos.SituacaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        RelatorioLaudos.SituacaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        ' RelatorioLaudos.SituacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", FrmAlvara.alvaraBindingSource, "Status", True))
        RelatorioLaudos.SituacaoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        RelatorioLaudos.SituacaoComboBox.FormattingEnabled = True
        RelatorioLaudos.SituacaoComboBox.Items.AddRange(New Object() {"Aguardando Cliente", "Aguardando Pagamento", "Aguardando Prefeitura", "Baixado", "Cadastro desatualizado", "Cancelado", "Em Andamento", "Finalizado Definitivo", "Finalizado Provisório", "Não Fazer", "Não Iniciado", "Paralisado", "Pendência", "Protocolado", "Saiu do Escritório"})
        ' RelatorioLaudos.SituacaoComboBox.Location = New System.Drawing.Point(421, 14)
        'RelatorioLaudos.SituacaoComboBox.Name = "StatusComboBox"
        ' RelatorioLaudos.SituacaoComboBox.Size = New System.Drawing.Size(207, 21)
        '  RelatorioLaudos.SituacaoComboBox.TabIndex = 10
        '
    End Sub

    '=============================================================================
    '=============================================================================
    '======================== LEGALIZAÇÃO - EMPRESAS ===================================
    '=============================================================================
    '=============================================================================

    Sub ComboboxLegalizacao()
        ' chamar usa  =>         ModCombobox.ComboboxLegalizacao()

        'StatusComboBox
        '
        FrmLegalizacao.StatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        FrmLegalizacao.StatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        'FrmLegalizacao.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Status", True))
        FrmLegalizacao.StatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        FrmLegalizacao.StatusComboBox.FormattingEnabled = True
        FrmLegalizacao.StatusComboBox.Items.AddRange(New Object() {"Não Iniciado", "Em Andamento", "Aguardando Cliente", "Aguardando Pagamento das Taxas", "Junta Comercial - Prefeitura: EM ANÁLISE", "Junta Comercial - Busca de Nome", "Junta Comercial - Aguardando Atualização", "Junta Comercial - Protocolado", "Receita Federal - DBE", "Receita Federal - e-Processo", "Receita Estadual - Em Andamento", "Receita Estadual - Protocolado", "Simples Nacional - Em Andamento", "Simples Nacional - Protocolado", "Prefeitura/Alvará - Em Andamento", "Finalizado", "Paralisado", "Cancelado", "Saiu do Escritório", "Pêndencia Sistema Externo"})
        'FrmLegalizacao.StatusComboBox.Location = New System.Drawing.Point(421, 14)
        'FrmLegalizacao.StatusComboBox.Name = "StatusComboBox"
        'FrmLegalizacao.StatusComboBox.Size = New System.Drawing.Size(207, 21)
        'FrmLegalizacao.StatusComboBox.TabIndex = 10
        '
    End Sub

    Sub ComboboxLegalizacaoProcesso()
        ' chamar usa  =>         ModCombobox.ComboboxLegalizacaoProcesso()

        'ProcessoComboBox
        '
        FrmLegalizacao.ProcessoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        FrmLegalizacao.ProcessoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        'FrmLegalizacao.ProcessoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Processo", True))
        FrmLegalizacao.ProcessoComboBox.FormattingEnabled = True
        FrmLegalizacao.ProcessoComboBox.Items.AddRange(New Object() {"Abertura", "Alteração", "Baixa", "Reativação", "Cancelado", "Outros", "Receita Estadual", "Receita Federal", "Prefeitura", "Transformação", "Incorporação", "Fusão", "Anulação de Atos", "Livro Digital"})
        'FrmLegalizacao.ProcessoComboBox.Location = New System.Drawing.Point(75, 87)
        FrmLegalizacao.ProcessoComboBox.Name = "ProcessoComboBox"
        'FrmLegalizacao.ProcessoComboBox.Size = New System.Drawing.Size(107, 21)
        'FrmLegalizacao.ProcessoComboBox.TabIndex = 12
        '
    End Sub

    'RELATÓRIOS

    Sub ComboboxRelatorioEmpresasStatus()
        ' chamar usa  =>         ModCombobox.ComboboxLegalizacao()

        'StatusComboBox
        '
        'RelatorioEmpresas.StatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        RelatorioEmpresas.StatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        'RelatorioEmpresas.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Status", True))
        RelatorioEmpresas.StatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        RelatorioEmpresas.StatusComboBox.FormattingEnabled = True
        RelatorioEmpresas.StatusComboBox.Items.AddRange(New Object() {"Não Iniciado", "Em Andamento", "Aguardando Cliente", "Aguardando Pagamento das Taxas", "Junta Comercial - Prefeitura: EM ANÁLISE", "Junta Comercial - Busca de Nome", "Junta Comercial - Aguardando Atualização", "Junta Comercial - Protocolado", "Receita Federal - DBE", "Receita Federal - e-Processo", "Receita Estadual - Em Andamento", "Receita Estadual - Protocolado", "Simples Nacional - Em Andamento", "Simples Nacional - Protocolado", "Prefeitura/Alvará - Em Andamento", "Finalizado", "Paralisado", "Cancelado", "Saiu do Escritório", "Pêndencia Sistema Externo"})
        'RelatorioEmpresas.StatusComboBox.Location = New System.Drawing.Point(421, 14)
        'RelatorioEmpresas.StatusComboBox.Name = "StatusComboBox"
        'RelatorioEmpresas.StatusComboBox.Size = New System.Drawing.Size(207, 21)
        'RelatorioEmpresas.StatusComboBox.TabIndex = 10
        '
    End Sub

    Sub ComboboxRelatorioProcesso()
        ' chamar usa  =>         ModCombobox.ComboboxLegalizacaoProcesso()

        'ProcessoComboBox
        '
        ' RelatorioEmpresas.ProcessoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        RelatorioEmpresas.ProcessoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        'RelatorioEmpresas.ProcessoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Processo", True))
        RelatorioEmpresas.ProcessoComboBox.FormattingEnabled = True
        RelatorioEmpresas.ProcessoComboBox.Items.AddRange(New Object() {"Abertura", "Alteração", "Baixa", "Reativação", "Cancelado", "Outros", "Receita Estadual", "Receita Federal", "Prefeitura", "Transformação", "Incorporação", "Fusão", "Anulação de Atos"})
        'RelatorioEmpresas.ProcessoComboBox.Location = New System.Drawing.Point(75, 87)
        RelatorioEmpresas.ProcessoComboBox.Name = "ProcessoComboBox"
        'RelatorioEmpresas.ProcessoComboBox.Size = New System.Drawing.Size(107, 21)
        'RelatorioEmpresas.ProcessoComboBox.TabIndex = 12
        '
    End Sub
End Module
