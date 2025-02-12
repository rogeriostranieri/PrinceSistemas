Public Class ListViewColumnSorter
    Implements IComparer

    ' Propriedades para armazenar a coluna e a ordem de classificação
    Public Property SortColumn As Integer
    Public Property Order As SortOrder

    ' Inicializar com valores padrão
    Public Sub New()
        SortColumn = 0
        Order = SortOrder.None
    End Sub

    ' Implementar o método Compare
    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Dim itemX As ListViewItem = CType(x, ListViewItem)
        Dim itemY As ListViewItem = CType(y, ListViewItem)

        ' Comparar os valores das colunas
        Dim compareResult As Integer = String.Compare(itemX.SubItems(SortColumn).Text, itemY.SubItems(SortColumn).Text)

        ' Retornar o resultado baseado na ordem
        If Order = SortOrder.Ascending Then
            Return compareResult
        ElseIf Order = SortOrder.Descending Then
            Return -compareResult
        Else
            Return 0
        End If
    End Function
End Class
