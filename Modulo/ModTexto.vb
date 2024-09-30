Module ModTexto
    Function LimpaTexto(ByVal sText As String) As String
        'Arrays com as letras normalizadas e as expressões regulares 
        'Têm de ter o mesmo tamanho
        Dim cLetters() As String = {"a", "e", "i", "o", "u", "c", "n", "A", "E", "I", "O", "U", "C", "N"}
        Dim regexPatterns() As String = {"(à|á|â|ã){1}", "(è|é|ê){1}", "(ì|í|î){1}", "(ò|ó|ô|õ){1}", "(ù|ú|û){1}", "ç{1}", "ñ{1}", "(À|Á|Â|Ã){1}", "(È|É|Ê){1}", "(Ì|Í|Î){1}", "(Ò|Ó|Ô|Õ){1}", "(Ù|Ú|Û){1}", "Ç{1}", "Ñ{1}"}
        'paragrafos 
        'São substituídos todos os caracteres num ciclo
        For index As Integer = 0 To cLetters.Length - 1
            sText = System.Text.RegularExpressions.Regex.Replace(sText, regexPatterns(index), cLetters(index))
        Next

        Return sText
    End Function
    'limpa enter dos paragrafos 
    Function LimpaEnter(ByVal sText As String) As String
        sText = sText.Replace(vbCrLf, " ")
        sText = sText.Replace(vbCr, " ")
        sText = sText.Replace(vbLf, " ")

        Return sText
    End Function

    ' Função para limpar caracteres, espaçamentos e substituir quebras de linha
    Public Function LimparTextoPersonalizado(sText As String) As String
        ' Remove espaços duplicados
        Dim textoSemEspacosDuplicados As String = System.Text.RegularExpressions.Regex.Replace(sText, "\s+", " ")

        ' Remove quebras de linha e substitui por ";"
        Dim textoFormatado As String = textoSemEspacosDuplicados.Replace(Environment.NewLine, ";")

        ' Remove espaços adicionais em torno do ponto e vírgula
        textoFormatado = System.Text.RegularExpressions.Regex.Replace(textoFormatado, "\s*;\s*", ";")

        ' Retorna o texto formatado
        Return textoFormatado
    End Function

    'limpa caracteres  : , . ; : - _ e outros
    Function LimpaCaracteres(ByVal sText As String) As String
        sText = sText.Replace(".", "")
        sText = sText.Replace(",", "")
        sText = sText.Replace(";", "")
        sText = sText.Replace(":", "")
        sText = sText.Replace("-", "")
        sText = sText.Replace("_", "")
        sText = sText.Replace("(", "")
        sText = sText.Replace(")", "")
        sText = sText.Replace("[", "")
        sText = sText.Replace("]", "")
        sText = sText.Replace("{", "")
        sText = sText.Replace("}", "")
        sText = sText.Replace("/", "")
        sText = sText.Replace("\\", "")
        sText = sText.Replace("!", "")
        sText = sText.Replace("?", "")
        sText = sText.Replace("`", "")
        sText = sText.Replace("~", "")
        sText = sText.Replace("@", "")
        sText = sText.Replace("#", "")
        sText = sText.Replace("$", "")
        sText = sText.Replace("%", "")
        sText = sText.Replace("^", "")
        sText = sText.Replace("&", "")
        sText = sText.Replace("*", "")
        sText = sText.Replace("(", "")
        sText = sText.Replace(")", "")
        sText = sText.Replace("_", "")
        sText = sText.Replace("+", "")
        sText = sText.Replace("=", "")
        sText = sText.Replace("|", "")

        Return sText
    End Function


    'deixas apenas numeros
    Function ApenasNumeros(ByVal sText As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(sText, "[^0-9]", "")
    End Function

    'Transformar em Toda letra maiuscula
    Function TodoMaiusculo(ByVal sText As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(sText, "[^A-Z]", "").ToUpper()
    End Function

    'Transformar em Toda letra Minuscula
    Function TodoMinusculo(ByVal sText As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(sText, "[^a-z]", "").ToLower()
    End Function

    'apenas letras
    Function ApenasLetras(ByVal sText As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(sText, "[^a-zA-Z]", "")
    End Function


End Module
