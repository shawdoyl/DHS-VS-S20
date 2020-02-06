Module Module1

    Sub Main()
        'Dim value As Decimal = 25.5
        'value.ToString("C")

        'Console.WriteLine(value)
        'Console.WriteLine(value.ToString("C"))
        'Console.WriteLine(value.ToString("X"))
        'TooManySpaces()
        TimesTable()
        Console.ReadLine()

    End Sub

    Sub TooManySpaces()

        Dim message As String
        message = "     Hallo     "
        Console.WriteLine(Len(message))
        message = Trim(message)
        Console.WriteLine(Len(message))

    End Sub

    Sub TimesTable()

        Dim result As Integer
        For i = 1 To 12

            'Console.WriteLine(i)

            For j = 1 To 12
                result = i * j
                Console.Write(result.ToString("C").PadLeft(8) & "|")
            Next

            Console.WriteLine()
            'Console.WriteLine()

        Next

    End Sub

End Module
