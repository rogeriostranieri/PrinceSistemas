Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Data
Imports System.Text.RegularExpressions
Imports Microsoft.ML
Imports Microsoft.ML.Data
Imports Lucene.Net.Analysis
Imports Lucene.Net.Analysis.Snowball
Imports Lucene.Net.Analysis.Tokenattributes
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
' Classe que representa os dados após a transformação.
Public Class PerguntaTransformed
    Public Property Pergunta As String
    Public Property SQLQuery As String
    Public Property Features As Single()
End Class
