Module ModTexto
    Function CleanText(ByVal sText As String) As String
        'Arrays com as letras normalizadas e as expressões regulares 
        'Têm de ter o mesmo tamanho
        Dim cLetters() As String = {"a", "e", "i", "o", "u", "c", "n", "A", "E", "I", "O", "U", "C", "N"}
        Dim regexPatterns() As String = {"(à|á|â|ã){1}", "(è|é|ê){1}", "(ì|í|î){1}", "(ò|ó|ô|õ){1}", "(ù|ú|û){1}", "ç{1}", "ñ{1}", "(À|Á|Â|Ã){1}", "(È|É|Ê){1}", "(Ì|Í|Î){1}", "(Ò|Ó|Ô|Õ){1}", "(Ù|Ú|Û){1}", "Ç{1}", "Ñ{1}"}

        'São substituídos todos os caracteres num ciclo
        For index As Integer = 0 To cLetters.Length - 1
            sText = System.Text.RegularExpressions.Regex.Replace(sText, regexPatterns(index), cLetters(index))
        Next

        Return sText
    End Function
End Module
