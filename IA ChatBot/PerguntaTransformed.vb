Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Data
Imports System.Text.RegularExpressions
Imports Microsoft.ML
Imports Microsoft.ML.Data

Public Class PerguntaTransformed
    Public Property Pergunta As String
    Public Property SQLQuery As String
    <ColumnName("Features")>
    Public Property Features As Single()
End Class

