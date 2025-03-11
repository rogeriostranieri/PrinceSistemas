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
' Classe que representa os dados lidos do CSV.
Public Class PerguntaData
    <LoadColumn(0)>
    Public Property Pergunta As String
    <LoadColumn(1)>
    Public Property SQLQuery As String
End Class
