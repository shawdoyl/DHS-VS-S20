Option Explicit On
Option Strict On
Option Compare Text

Module Module1

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        firstNumber = 5
        secondNumber = 7

        result = firstNumber + secondNumber

        'LoopCount also works
        For i = 0 To 1000
            result = result + 3
        Next

        Console.Write(result)
        Console.Read()

    End Sub

End Module
