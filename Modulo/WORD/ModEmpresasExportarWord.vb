Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word

Module ModEmpresasExportarWord

    'criar documento word
    Public Sub CriarDocumentoWord()


        Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document
        Dim rng As Microsoft.Office.Interop.Word.Range
        Dim str As String = "testando"

        doc = word.Documents.Open("C:\Users\User\Downloads\testando.docx")
        rng = doc.Range(0, doc.Characters.Count)
        rng.Find.ClearFormatting()

        rng.Find.Text = "@escola"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = "Escola de Teste"
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        '@Rogerio por "testando 123"
        rng.Find.Text = "@Rogerio"
        rng.Find.Replacement.ClearFormatting()
        rng.Find.Replacement.Text = "testando 123"
        rng.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        doc.SaveAs("C:\Users\User\Downloads\testando.docx")
        doc.Close()
        word.Quit()


    End Sub

End Module
