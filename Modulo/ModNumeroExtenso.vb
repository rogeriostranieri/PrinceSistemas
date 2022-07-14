Imports Microsoft.Office.Interop.Word

Module ModNumeroExtenso

    Public Function NumberToEuro(ByVal number As Decimal) As String
        Dim cent As Integer
        Try

            ' se for = 0 retorna 0 eros
            If number = 0 Then
                Return "Zero Euros"
            End If

            ' Verifica a parte decimal, ou seja, os cêntimos
            cent = Decimal.Round((number - Int(number)) * 100,
                                 MidpointRounding.ToEven)

            ' Verifica apenas a parte inteira
            number = Int(number)

            ' Caso existam cêntimos
            If cent > 0 Then

                ' Caso seja 1 não coloca "euros" mas sim "euro"
                If number = 1 Then
                    Return "Um Euro e " & getDecimal(cent) & "Cêntimos"
                    ' Caso o valor seja inferior a 1 euro
                ElseIf number = 0 Then
                    Return getDecimal(cent) & "Cêntimos"
                Else
                    Return getInteger(number) & "Euros e " &
                        getDecimal(cent) & "Cêntimos"
                End If

            Else
                ' Caso seja 1 não coloca "euros" mas sim "euro"
                If number = 1 Then
                    Return "Um Euro"
                Else
                    Return getInteger(number) + "Euros"
                End If

            End If

        Catch ex As Exception
            Return String.Empty
        End Try

    End Function


    ''' <summary>
    ''' Função auxiliar - Parte decimal a converter
    ''' </summary>
    ''' <param name="number">Parte decimal a converter</param>
    Public Function GetDecimal(ByVal number As Byte) As String
        Try

            Select Case number
                Case 0
                    Return String.Empty
                Case 1 To 19
                    Dim strArray() As String =
                        {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis",
                        "Sete", "Oito", "Nove", "Dez", "Onze",
                        "Doze", "Treze", "Quatorze", "Quinze",
                        "Dezasseis", "Dezassete", "Dezoito", "Dezanove"}
                    Return strArray(number - 1) & " "

                Case 20 To 99
                    Dim strArray() As String =
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta",
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}

                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2) & " "
                    Else
                        Return strArray(number \ 10 - 2) & " e " &
                            GetDecimal(number Mod 10) & " "
                    End If
                Case Else
                    Return String.Empty
            End Select

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function


    ''' <summary>
    ''' Função auxiliar - Parte inteira a converter
    ''' </summary>
    ''' <param name="number">Parte inteira a converter</param>
    Public Function GetInteger(ByVal number As Decimal) As String
        Try

            number = Int(number)

            Select Case number
                Case Is < 0
                    Return "-" & GetInteger(-number)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                        {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis",
                        "Sete", "Oito", "Nove", "Dez", "Onze", "Doze",
                        "Treze", "Quatorze", "Quinze", "Dezasseis",
                        "Dezassete", "Dezoito", "Dezanove"}
                    Return strArray(number - 1) & " "

                Case 20 To 99
                    Dim strArray() As String =
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta",
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}

                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) & " e " &
                            GetInteger(number Mod 10)
                    End If

                Case 100
                    Return "Cem"

                Case 101 To 999
                    Dim strArray() As String =
                       {"Cento", "Duzentos", "Trezentos", "Quatrocentos",
                            "Quinhentos", "Seiscentos", "Setecentos",
                            "Oitocentos", "Novecentos"}

                    If (number Mod 100) = 0 Then
                        Return strArray(number \ 100 - 1) & " "
                    Else
                        Return strArray(number \ 100 - 1) & " e " &
                            GetInteger(number Mod 100)
                    End If


                Case 1000 To 1999
                    Select Case (number Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return "Mil e " & GetInteger(number Mod 1000)
                        Case Else
                            Return "Mil, " & GetInteger(number Mod 1000)
                    End Select


                Case 2000 To 999999
                    Select Case (number Mod 1000)
                        Case 0
                            Return GetInteger(number \ 1000) & "Mil"
                        Case Is <= 100
                            Return GetInteger(number \ 1000) & "Mil e " &
                                GetInteger(number Mod 1000)
                        Case Else
                            Return GetInteger(number \ 1000) & "Mil, " &
                                GetInteger(number Mod 1000)
                    End Select


                Case 1000000 To 1999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return "Um Milhão"
                        Case Is <= 100
                            Return GetInteger(number \ 1000000) & "Milhão e " &
                                GetInteger(number Mod 1000000)
                        Case Else
                            Return GetInteger(number \ 1000000) & "Milhão, " &
                                GetInteger(number Mod 1000000)
                    End Select


                Case 2000000 To 999999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return GetInteger(number \ 1000000) & " Milhões"
                        Case Is <= 100
                            Return GetInteger(number \ 1000000) & "Milhões e " &
                                GetInteger(number Mod 1000000)
                        Case Else
                            Return GetInteger(number \ 1000000) & "Milhões, " &
                                GetInteger(number Mod 1000000)
                    End Select


                Case 1000000000 To 1999999999
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return "Um Bilião"
                        Case Is <= 100
                            Return GetInteger(number \ 1000000000) & "Bilião e " &
                                GetInteger(number Mod 1000000000)
                        Case Else
                            Return GetInteger(number \ 1000000000) & "Bilião, " &
                                GetInteger(number Mod 1000000000)
                    End Select


                Case Else
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return GetInteger(number \ 1000000000) & "Mil Milhões"

                        Case Is <= 100
                            Return GetInteger(number \ 1000000000) & "Mil Milhões e " &
                                GetInteger(number Mod 1000000000)
                        Case Else
                            Return GetInteger(number \ 1000000000) & "Mil Milhões, " &
                                GetInteger(number Mod 1000000000)
                    End Select
            End Select


        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

End Module
