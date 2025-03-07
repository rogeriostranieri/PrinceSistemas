Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Data
Imports System.Text.RegularExpressions
Imports Microsoft.ML
Imports Microsoft.ML.Data
Public Class PerguntaData
    <LoadColumn(0)>
    Public Property Pergunta As String
    <LoadColumn(1)>
    Public Property SQLQuery As String
End Class
