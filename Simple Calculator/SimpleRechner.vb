'Doyle_Shaw
'RCET0265
'Spring_2020
'Simple_Calculator
'https://github.com/shawdoyl/DHS-VS-S20

Module SimpleRechner

    Sub Main()

        Dim firstNumber As String
        Dim secondNumber As String
        Dim mathSymbol As String

        Console.WriteLine("Please enter first number. Press Enter to proceed.")
        firstNumber = Console.ReadLine()
        Console.WriteLine("Please enter second number. Press Enter to proceed.")
        secondNumber = Console.ReadLine()
        Console.WriteLine("Please enter desired function of product(*) or sum(+). Press Enter to finish calcultion.")
        mathSymbol = Console.ReadLine()

        If mathSymbol = "+" Then
            Console.WriteLine(firstNumber & "+" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
        ElseIf mathSymbol = "Sum" Then
            Console.WriteLine(firstNumber & "+" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
        ElseIf mathSymbol = "*" Then
            Console.WriteLine(firstNumber & "*" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))
        ElseIf mathSymbol = "Product" Then
            Console.WriteLine(firstNumber & "*" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))
        Else
            Console.WriteLine("That is not an appropiate Response.")
        End If

        Console.ReadLine()

    End Sub

End Module
