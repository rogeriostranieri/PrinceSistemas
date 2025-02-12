Public Class DialogAjudaObjetoEmpresa

    Private Sub DialogAjudaObjetoEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Definindo o texto com a fonte 11
        RichTextBox1.Font = New Font("Arial", 11)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.AppendText("A diferença entre \'Descrição Do Objeto Do Estabelecimento\' e \'Descrição Do Objeto da Empresa\' está relacionada ao escopo e ao nível de detalhe de cada descrição." & vbCrLf & vbCrLf)

        ' Adicionando subtítulo e conteúdo da "Descrição do Objeto do Estabelecimento"
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.AppendText("Descrição do Objeto do Estabelecimento:" & vbCrLf)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText("Refere-se à atividade específica desenvolvida no local (estabelecimento)." & vbCrLf)
        RichTextBox1.AppendText("Descreve o que é vendido ou oferecido no local." & vbCrLf)
        RichTextBox1.AppendText("É mais focada na operação diária do negócio." & vbCrLf & vbCrLf)

        ' Adicionando subtítulo e conteúdo da "Descrição do Objeto da Empresa"
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.AppendText("Descrição do Objeto da Empresa:" & vbCrLf)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText("Refere-se ao objetivo principal da empresa como um todo." & vbCrLf)
        RichTextBox1.AppendText("Descreve a natureza da atividade econômica da empresa." & vbCrLf)
        RichTextBox1.AppendText("É mais ampla e abrange a visão global da empresa." & vbCrLf & vbCrLf)

        ' Seção adicional - SENDO MAIS ESPECÍFICO
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.AppendText("SENDO MAIS ESPECÍFICO:" & vbCrLf & vbCrLf)

        ' Detalhes da Descrição do Objeto da Empresa
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.AppendText("Descrição do Objeto da Empresa:" & vbCrLf)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText("• É o que é registrado no Contrato Social (ou Estatuto) da empresa." & vbCrLf)
        RichTextBox1.AppendText("• Define o objetivo principal da empresa, sua atividade econômica e o ramo em que atua." & vbCrLf)
        RichTextBox1.AppendText("• É uma descrição mais ampla e genérica." & vbCrLf)
        RichTextBox1.AppendText("• É um documento público e oficial." & vbCrLf & vbCrLf)

        ' Detalhes da Descrição do Objeto do Estabelecimento
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.AppendText("Descrição do Objeto do Estabelecimento:" & vbCrLf)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText("• É uma descrição mais específica das atividades desenvolvidas no local." & vbCrLf)
        RichTextBox1.AppendText("• Pode incluir detalhes sobre os produtos ou serviços oferecidos." & vbCrLf)
        RichTextBox1.AppendText("• Não precisa ser necessariamente incluída no Contrato Social." & vbCrLf)
        RichTextBox1.AppendText("• Pode variar de acordo com o estabelecimento específico." & vbCrLf & vbCrLf)

        ' Exemplo para esclarecer a diferença
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.AppendText("Exemplo:" & vbCrLf)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText("Descrição do Objeto da Empresa (Contrato Social):" & vbCrLf)
        RichTextBox1.AppendText("""Comércio de alimentos e bebidas.""" & vbCrLf)
        RichTextBox1.AppendText("Descrição do Objeto do Estabelecimento:" & vbCrLf)
        RichTextBox1.AppendText("""Comércio de pizzas, esfirras, lanches, porções, doces, bolos, bebidas e refrigerantes.""" & vbCrLf & vbCrLf)

        ' Conclusão
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.AppendText("Nesse exemplo:" & vbCrLf)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText("A Descrição do Objeto da Empresa é mais genérica e define o ramo de atuação, enquanto a Descrição do Objeto do Estabelecimento é mais específica e detalha os produtos oferecidos.")
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
